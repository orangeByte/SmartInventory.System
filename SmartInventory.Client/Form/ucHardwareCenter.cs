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


namespace SmartInventory.Client.Form
{
	public partial class ucHardwareCenter : DevExpress.XtraEditors.XtraUserControl
	{
		BindingList<ScanLog> scanLogs = new();
		SerialPortManager serialDataManager = new();

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

			simpleButton1.Enabled = true;
			simpleButton2.Enabled = false;
			simpleLabelItem1.Text = "状态：已断开";

			serialDataManager.OnDataParsed += (buffer, hex) =>
			{
				this.Invoke(new Action(() =>
				{
					memoEdit1.AppendText($"[{DateTime.Now:T}] RX:{hex} \r\n");

					string SN = Encoding.ASCII.GetString(buffer).Trim();
					scanLogs.Insert(0, new ScanLog
					{
						Time = DateTime.Now,
						SN = SN,
						ProductName = $"模拟数据{System.Guid.NewGuid().ToString()}",
						Status = "0"
					});
					serialDataManager.SendData("OK");
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
				simpleLabelItem1.Text = "状态：已连接";
				simpleButton1.Enabled = false;
				simpleButton2.Enabled = true;
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
				simpleButton1.Enabled = true;
				simpleButton2.Enabled = false;
				comboBoxEdit1.Enabled = true;
				simpleLabelItem1.Text = "状态：已断开";
				memoEdit1.AppendText($"[{DateTime.Now:T}] --- 串口已手动断开 --- \r\n");
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show($"关闭串口时发现异常{ex.Message}");
			}


		}
	}
}
