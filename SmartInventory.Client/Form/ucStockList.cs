using DevExpress.Mvvm;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraSplashScreen;
using SmartInventory.Client.Form;
using SmartInventory.Models.Models;
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

namespace SmartInventory.Client
{
	public partial class ucStockList : DevExpress.XtraEditors.XtraUserControl
	{
		public ucStockList()
		{
			InitializeComponent();
		}

		private async void gridControl1_Load(object sender, EventArgs e)
		{
			await RefreshData();
		}

		private async Task RefreshData()
		{
			IOverlaySplashScreenHandle handle = SplashScreenManager.ShowOverlayForm(gridControl1);
			try
			{
				using var http = new HttpClient();
				var data = await http.GetFromJsonAsync<List<Product>>("http://localhost:5016/api/Product");

				gridControl1.DataSource = data;
				gridView1.OptionsBehavior.Editable = false;
				gridView1.OptionsFind.AlwaysVisible = true;
			}
			catch (Exception ex)
			{
				{
					MessageBox.Show($"数据加载错误: {ex.Message}");
				}
			}
			finally
			{
				SplashScreenManager.CloseOverlayForm(handle);
			}
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new()
			{
				Title = "导出库存列表",
				Filter = "Excel 文件 (*.xlsx)|*.xlsx",
				FileName = $"库存清单_{DateTime.Now:yyyyMMdd}"

			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				XlsxExportOptionsEx optionsEx = new();
				optionsEx.ExportType = DevExpress.Export.ExportType.WYSIWYG;

				string path = saveFileDialog.FileName;
				gridControl1.ExportToXlsx(path, optionsEx);
				if (XtraMessageBox.Show("导出成功, 是否查看?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(path) { UseShellExecute = true });
				}
			}

		}

		private async void simpleButton2_Click(object sender, EventArgs e)
		{
			using var frm = new frmProductEdit(new Product());
			frm.StartPosition = FormStartPosition.CenterParent;

			if (frm.ShowDialog() == DialogResult.OK)
			{
				await RefreshData();
			}
		}

		private async void gridView1_DoubleClick(object sender, EventArgs e)
		{
			var product = gridView1.GetFocusedRow() as Product;
			if (product == null) return;

			using var frm = new frmProductEdit(product);
			frm.StartPosition = FormStartPosition.CenterParent;

			if (frm.ShowDialog() == DialogResult.OK)
			{
				await RefreshData();
			}
		}

		private async void simpleButton3_Click(object sender, EventArgs e)
		{
			var product = gridView1.GetFocusedRow() as Product;
			if (product == null) return;

			DialogResult dialogResult = XtraMessageBox.Show(
				$"你确定要删除产品{product.Name}, 删除后数据将进入回收站",
				"操作确定",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (dialogResult == DialogResult.Yes)
			{
				try
				{
					var handle = SplashScreenManager.ShowOverlayForm(gridControl1);

					using var client = new HttpClient();
					var rep = await client.DeleteAsync($"http://localhost:5016/api/Product/{product.Id}");

					if (rep.IsSuccessStatusCode)
					{
						await RefreshData();
						XtraMessageBox.Show("删除成功");
					}
					else
					{
						XtraMessageBox.Show($"删除失败{rep.ReasonPhrase}");
					}

					SplashScreenManager.CloseOverlayForm(handle);
				}
				catch (Exception ex)
				{
					XtraMessageBox.Show($"删除失败, {ex}");
				}
			}
		}
	}
}
