using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace SmartInventory.Client
{
	static class Tools
	{
		public static void OpenModule<T>(this TabbedView tabbedView, string caption) where T : UserControl, new()
		{
			var document = tabbedView.Documents.FirstOrDefault(x => x.Control is T);
			if (document != null)
			{
				tabbedView.Controller.Activate(document);
			}
			else
			{
				T control = new() { Name = typeof(T).Name};
				var newdoc = tabbedView.AddDocument(control);
				newdoc.Caption = caption;
				tabbedView.Controller.Activate(newdoc);

			}
		}

		public class HttpHelper()
		{
			private static readonly HttpClient _httpClient = new()
			{
				BaseAddress = new Uri("http://localhost:5016"),
				Timeout = TimeSpan.FromSeconds(30)
			};

			public static string AccessToken { get; set; }

			private static void EnsureHeader()
			{
				_httpClient.DefaultRequestHeaders.Authorization =
					!string.IsNullOrEmpty(AccessToken)
					? new AuthenticationHeaderValue("Bearer", AccessToken)
					: null;
			}

			public static async Task<T> GetAsync<T>(string url)
			{
				EnsureHeader();
				return await _httpClient.GetFromJsonAsync<T>(url);
			}

			public static async Task<HttpResponseMessage> PostAsync<T>(string url, T data)
			{
				EnsureHeader();
				return await _httpClient.PostAsJsonAsync(url, data);
			}

			public static async Task<HttpResponseMessage> PutAsync<T>(string url, T data)
			{
				EnsureHeader();
				return await _httpClient.PutAsJsonAsync(url, data);
			}

			public static async Task<HttpResponseMessage> DeleteAsync(string url)
			{
				EnsureHeader();
				return await _httpClient.DeleteAsync(url);
			}
		}

		public static string GetCurUsername()
		{
			var handler = new JwtSecurityTokenHandler();
			var jwttoekn = handler.ReadJwtToken(HttpHelper.AccessToken);

			var username = jwttoekn.Claims.FirstOrDefault(x => x.Type == "sub")?.Value;

			return username;
		}

		public static string GetCurRole()
		{
			var handler = new JwtSecurityTokenHandler();
			var jwttoekn = handler.ReadJwtToken(HttpHelper.AccessToken);

			var role = jwttoekn.Claims.FirstOrDefault(x => x.Type.Contains("role"))?.Value;

			return role;

		}

		public class SerialPortManager
		{
			private SerialPort _serialPort;

			public event Action<byte[], string> OnDataParsed;
			public event Action<string> OnStatusChanged;

			public void Open(string portName, int baudRate = 9600)
			{
				try
				{
					if (_serialPort != null && _serialPort.IsOpen)
					{
						_serialPort.Close();
					}

					_serialPort = new SerialPort(portName, baudRate);
					_serialPort.DataBits = 8;
					_serialPort.StopBits = StopBits.One;
					_serialPort.Parity = Parity.None;

					_serialPort.DataReceived += (sender, e) =>
					{
						int bytesToRead = _serialPort.BytesToRead;
						byte[] buffer = new byte[bytesToRead];
						_serialPort.Read(buffer, 0, bytesToRead);

						string hex = BitConverter.ToString(buffer).Replace("-", " ");

						OnDataParsed?.Invoke(buffer, hex);
					};

					_serialPort.Open();
				}
				catch (Exception ex)
				{
					this.OnStatusChanged?.Invoke(ex.Message);
				}

			}

			public void Close()
			{
				try
				{
					if (_serialPort != null && _serialPort.IsOpen)
					{
						_serialPort.Close();
					}
				}
				catch (Exception ex)
				{

					this.OnStatusChanged?.Invoke(ex.Message);
				}
			}

			public void SendData(string data)
			{
				try
				{
					if (_serialPort != null && _serialPort.IsOpen)
					{
						byte[] buffer = Encoding.ASCII.GetBytes(data);
						_serialPort.Write(buffer, 0, buffer.Length);
					}
				}
				catch (Exception ex)
				{
					this.OnStatusChanged?.Invoke(ex.Message);
				}

			}
		}

		public class SocketManager
		{
			private Socket _serverSocket;
			private List<Socket> _clientSockets = [];
			public event Action<string, string, Socket> OnMessageReceived;
			public event Action<string> OnStatusChanged;

			public void Start(int port)
			{
				try
				{
					_serverSocket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

					_serverSocket.Bind(new IPEndPoint(IPAddress.Any, port));

					_serverSocket.Listen(10);

					OnStatusChanged?.Invoke($"服务器监听已开启, 正在监听端口{port}");

					_serverSocket.BeginAccept(AcceptCallback, null);
				}
				catch (Exception ex)
				{
					OnStatusChanged?.Invoke($"监听启动失败{ex.Message}");
				}


			}

			private void AcceptCallback(IAsyncResult ir)
			{

				if (_serverSocket == null) return;

				try
				{
					Socket clientSocket = _serverSocket.EndAccept(ir);
					_clientSockets.Add(clientSocket);

					string clientInfo = clientSocket.RemoteEndPoint.ToString();

					OnStatusChanged?.Invoke($"连接成功, 客户端来自 {clientInfo}");

					byte[] buffer = new byte[1024];

					clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, new object[] { clientSocket, buffer });

					_serverSocket.BeginAccept(AcceptCallback, null);
				}
				catch (Exception ex)
				{

					OnStatusChanged?.Invoke($"接收连接失败: {ex.Message}");
				}
			}
			

			private void ReceiveCallback(IAsyncResult ar)
			{
				object[]? objects = ar.AsyncState as object[];
				Socket clientSocket = objects[0] as Socket;
				byte[] buffer = objects[1] as byte[];

				try
				{
					int length = clientSocket.EndReceive(ar);
					if (length > 0)
					{
						string msg = Encoding.UTF8.GetString(buffer, 0, length);
						string clientInfo = clientSocket.RemoteEndPoint.ToString();
						OnMessageReceived?.Invoke(clientInfo, msg, clientSocket);
						clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, objects);
					}
					else
					{
						OnStatusChanged?.Invoke($"客户端断开连接: {clientSocket.RemoteEndPoint.ToString()}");
						clientSocket.Close();
					}
				}
				catch (Exception ex)
				{
					OnStatusChanged?.Invoke($"接收数据异常: {ex.Message}");
				}
			}

			public void Stop()
			{
				try
				{
					_clientSockets.ForEach(x =>
					{
						if (x != null && x.Connected)
						{
							x.Shutdown(SocketShutdown.Both);
							x.Close();
						}
					});

					_clientSockets.Clear();

					if(_serverSocket != null)
					{
						_serverSocket.Close();
						_serverSocket = null;
					}

					this.OnStatusChanged?.Invoke($"Socket服务器已停止监听");
				}
				catch (Exception ex)
				{

					this.OnStatusChanged?.Invoke($"关闭Socket时出错, {ex.Message}");
				}
			}

			public void SendData(string data, Socket socket)
			{
				try
				{
					byte[] buffer = Encoding.UTF8.GetBytes(data);
					socket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, (ar) =>
					{
						socket.EndSend(ar);
					}, null);
				}
				catch (Exception ex)
				{
					OnStatusChanged?.Invoke($"发送数据失败: {ex.Message}");
				}
			}


		}
	}

	
}
