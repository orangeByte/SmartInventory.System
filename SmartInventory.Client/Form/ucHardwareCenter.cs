using DevExpress.XtraEditors;
using SmartInventory.Models.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using static SmartInventory.Client.Tools;
using SmartInventory.Models.Models;
using System.Net.Sockets;


namespace SmartInventory.Client.Form
{
	public partial class ucHardwareCenter : DevExpress.XtraEditors.XtraUserControl
	{
		BindingList<ScanLog> scanLogs = new();
		SerialPortManager serialDataManager = new();
		SocketManager socketManager = new();
		ScanLog ScanLog = null;

		public ucHardwareCenter()
		{
			InitializeComponent();
		}

		private void ucHardwareCenter_Load_1(object sender, EventArgs e)
		{
			gridControl1.DataSource = scanLogs;
			string[] portNames = SerialPort.GetPortNames();

			comboBoxEdit1.Properties.Items.Clear();
			comboBoxEdit1.Properties.Items.AddRange(portNames);
			if (comboBoxEdit1.Properties.Items.Count > 0)
			{
				comboBoxEdit1.SelectedIndex = 0;
			}

			gridView1.OptionsView.ShowGroupPanel = false;
			gridView1.OptionsBehavior.Editable = false;

			serial_con.Enabled = true;
			serial_dis.Enabled = false;
			socket_con.Enabled = true;
			socket_dis.Enabled = false;
			textEdit1.Text = "8080";
			simpleLabelItem2.Text = "网络状态: 已断开";
			simpleLabelItem1.Text = "串口状态：已断开";


			serialDataManager.OnDataParsed += async (buffer, hex) =>
			{
				string SN = Encoding.ASCII.GetString(buffer).Trim();
				await ProcessNewDataAsync(SN, "串口", hex, 1, null);
			};

			socketManager.OnMessageReceived += async (ip, msg, socket) =>
			{
				await ProcessNewDataAsync(msg.Trim(), $"Socket{ip}", "null", 2, socket);
			};

			serialDataManager.OnStatusChanged += (msg) =>
			{
				this.Invoke(new Action(() =>
				{
					memoEdit1.AppendText($"[{DateTime.Now:T}] 串口系统:{msg}");
				}));
			};

			socketManager.OnStatusChanged += (msg) =>
			{
				this.Invoke(new Action(() =>
				{
					memoEdit1.AppendText($"[{DateTime.Now:T}] 网络系统:{msg}");
				}));
			};
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			try
			{
				string? portName = comboBoxEdit1.SelectedItem?.ToString();
				if (string.IsNullOrWhiteSpace(portName)) return;

				serialDataManager.Open(portName);
				simpleLabelItem1.Text = "串口状态：已连接";
				serial_con.Enabled = false;
				serial_dis.Enabled = true;
				comboBoxEdit1.Enabled = false;
				memoEdit1.AppendText($"[{DateTime.Now:T}] --- 串口已手动打开 --- \r\n");


			}
			catch (Exception ex)
			{
				XtraMessageBox.Show("连接失败" + ex.Message);
			}
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			try
			{
				serialDataManager.Close();
				serial_con.Enabled = true;
				serial_dis.Enabled = false;
				comboBoxEdit1.Enabled = true;
				simpleLabelItem1.Text = "串口状态：已断开";
				memoEdit1.AppendText($"[{DateTime.Now:T}] --- 串口已手动断开 --- \r\n");
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show($"关闭串口时发现异常{ex.Message}");
			}


		}

		private async Task<bool> SaveToSys(ScanLog scanLog)
		{
			try
			{
				Product product = new()
				{
					Name = scanLog.SN,
					Price = 0,
					Stock = "1"
				};
				var rep = await HttpHelper.PostAsync("api/Product", product);

				if (rep.IsSuccessStatusCode)
				{
					return true;
				}
				else
				{
					return false;
				}

			}
			catch (Exception ex)
			{
				return false;
			}
		}

		private void socket_con_Click(object sender, EventArgs e)
		{
			try
			{
				string? portName = textEdit1.Text;
				if (string.IsNullOrWhiteSpace(portName)) return;

				socketManager.Start(int.Parse(portName));
				simpleLabelItem2.Text = "网络状态：已连接";
				socket_con.Enabled = false;
				socket_dis.Enabled = true;
				textEdit1.Enabled = false;
				memoEdit1.AppendText($"[{DateTime.Now:T}] --- Socket监听已手动打开 --- \r\n");


			}
			catch (Exception ex)
			{
				XtraMessageBox.Show("连接失败" + ex.Message);
			}
		}

		private void socket_dis_Click(object sender, EventArgs e)
		{
			try
			{
				socketManager.Stop();
				socket_con.Enabled = true;
				socket_dis.Enabled = false;
				textEdit1.Enabled = true;
				simpleLabelItem2.Text = "网络状态：已断开";
				memoEdit1.AppendText($"[{DateTime.Now:T}] --- 网络已手动断开 --- \r\n");
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show($"关闭网络时发现异常{ex.Message}");
			}
		}

		private async Task ProcessNewDataAsync(string SN, string source, string hex, int sourceFlag, Socket socket)
		{
			ScanLog = new ScanLog
			{
				Time = DateTime.Now,
				SN = SN,
				ProductName = $"模拟数据{System.Guid.NewGuid().ToString()}, 来自{source}",
				Status = "0"
			};

			bool flag = await SaveToSys(ScanLog);
			this.Invoke(new Action(() =>
			{
				memoEdit1.AppendText($"[{DateTime.Now:T}] RX:{hex}, 来自{source} \r\n");

				scanLogs.Insert(0, ScanLog);

				if (sourceFlag == 1)
				{
					serialDataManager.SendData(flag ? "OK" : "ERR");
				}
				else if (sourceFlag == 2)
				{
					socketManager.SendData(flag ? "OK" : "ERR", socket);
				}
			}));
		}
	}
}
