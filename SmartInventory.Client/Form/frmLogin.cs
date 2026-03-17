using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using SmartInventory.Models.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SmartInventory.Client.Tools;

namespace SmartInventory.Client.Form
{
	public partial class frmLogin : DevExpress.XtraEditors.XtraForm
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private async void simpleButton1_Click(object sender, EventArgs e)
		{

			if (string.IsNullOrWhiteSpace(textEdit1.Text) || string.IsNullOrWhiteSpace(textEdit2.Text))
			{
				XtraMessageBox.Show("用户名或密码为空");
				return;
			}

			var handle = SplashScreenManager.ShowOverlayForm(this);

			try
			{

				simpleButton1.Enabled = false;

				var loginDto = new { username = textEdit1.Text, password = textEdit2.Text };

				using var client = new HttpClient();
				client.BaseAddress = new Uri("http://localhost:5016/");

				var rep = await client.PostAsJsonAsync("api/Auth", loginDto);

				if (rep.IsSuccessStatusCode)
				{
					var result = await rep.Content.ReadFromJsonAsync<LoginResponseDto>();

					HttpHelper.AccessToken = result.Token;

					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else
				{
					XtraMessageBox.Show($"登入失败{rep.ReasonPhrase}");
				}
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show($"发生了未知错误{ex}");
			}
			finally
			{
				SplashScreenManager.CloseOverlayForm(handle);
				simpleButton1.Enabled = true;
			}
		}
	}
}