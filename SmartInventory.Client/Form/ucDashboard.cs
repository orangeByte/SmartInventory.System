using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
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
using static SmartInventory.Client.Tools;

namespace SmartInventory.Client.Form
{
	public partial class ucDashboard : DevExpress.XtraEditors.XtraUserControl
	{
		public ucDashboard()
		{
			InitializeComponent();
		}

		private void ucDashboard_Load(object sender, EventArgs e)
		{
			Refresh();
		}

		public async void Refresh()
		{
			var data = await HttpHelper.GetAsync<DashboardDto>("/api/DashBoard");

			labelControl1.Text = $"产品种类: {data.TotalProductCount}";
			labelControl2.Text = $"全部库存: {data.TotalStock}";
			labelControl3.Text = $"全部价值: {Math.Round(data.TotalValue, 2)}";
			labelControl4.Text = $"低库存: {data.LowStockAlertCount}";

			chartControl1.DataSource = data.PieData;

			var pieSeries = chartControl1.Series[0];
			pieSeries.ArgumentDataMember = "Label";
			pieSeries.ValueDataMembers.AddRange("Value");
			pieSeries.LegendTextPattern = "{A}: {VP:P0}";

			chartControl2.DataSource = data.BarData;

			var barSeries = chartControl2.Series[0];
			barSeries.ArgumentDataMember = "Label";
			barSeries.ValueDataMembers.AddRange("Value");
		}

		private void chartControl1_CustomDrawSeriesPoint(object sender, DevExpress.XtraCharts.CustomDrawSeriesPointEventArgs e)
		{
			string label = e.SeriesPoint.Argument;

			var targetColor = label switch
			{
				var s when s.Contains("预警") => Color.Red,
				var s when s.Contains("健康") => Color.Green,
				var s when s.Contains("积压") => Color.Orange,
				_ => e.SeriesDrawOptions.Color
			};

			e.SeriesDrawOptions.Color = targetColor;

			e.LegendDrawOptions.Color = targetColor;
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			Refresh();
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				PrintableComponentLink link = new(new PrintingSystem())
				{
					Component = layoutControl1,
					Landscape = true,
					PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
				};

				string filepath = "库存监控看板回执.pdf";
				link.VerticalContentSplitting = VerticalContentSplitting.Smart;
				layoutControlItem8.OptionsPrint.AllowPrint = false;
				layoutControlItem7.OptionsPrint.AllowPrint = false;
				emptySpaceItem2.OptionsPrint.AllowPrint = false;
				emptySpaceItem4.OptionsPrint.AllowPrint = false;

				link.ExportToPdf(filepath);

				var psi = new System.Diagnostics.ProcessStartInfo
				{
					FileName = filepath,
					UseShellExecute = true,
				};

				System.Diagnostics.Process.Start(psi);
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show($"导出错误{ex}");
			}
			finally
			{
				Cursor = Cursors.Default;
			}

		}
	}
}
