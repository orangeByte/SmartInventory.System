namespace SmartInventory.Client.Form
{
	partial class ucDashboard
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
			DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
			DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
			layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			chartControl2 = new DevExpress.XtraCharts.ChartControl();
			chartControl1 = new DevExpress.XtraCharts.ChartControl();
			panelControl4 = new DevExpress.XtraEditors.PanelControl();
			labelControl4 = new DevExpress.XtraEditors.LabelControl();
			panelControl3 = new DevExpress.XtraEditors.PanelControl();
			labelControl3 = new DevExpress.XtraEditors.LabelControl();
			panelControl2 = new DevExpress.XtraEditors.PanelControl();
			labelControl2 = new DevExpress.XtraEditors.LabelControl();
			panelControl1 = new DevExpress.XtraEditors.PanelControl();
			labelControl1 = new DevExpress.XtraEditors.LabelControl();
			Root = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
			layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)chartControl2).BeginInit();
			((System.ComponentModel.ISupportInitialize)xyDiagram1).BeginInit();
			((System.ComponentModel.ISupportInitialize)series1).BeginInit();
			((System.ComponentModel.ISupportInitialize)chartControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)series2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pieSeriesView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)panelControl4).BeginInit();
			panelControl4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)panelControl3).BeginInit();
			panelControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
			panelControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
			panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)Root).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
			SuspendLayout();
			// 
			// layoutControl1
			// 
			layoutControl1.Controls.Add(chartControl2);
			layoutControl1.Controls.Add(chartControl1);
			layoutControl1.Controls.Add(panelControl4);
			layoutControl1.Controls.Add(panelControl3);
			layoutControl1.Controls.Add(panelControl2);
			layoutControl1.Controls.Add(panelControl1);
			layoutControl1.Dock = DockStyle.Fill;
			layoutControl1.Location = new Point(0, 0);
			layoutControl1.Name = "layoutControl1";
			layoutControl1.Root = Root;
			layoutControl1.Size = new Size(966, 576);
			layoutControl1.TabIndex = 0;
			layoutControl1.Text = "layoutControl1";
			// 
			// chartControl2
			// 
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
			xyDiagram1.Rotated = true;
			chartControl2.Diagram = xyDiagram1;
			chartControl2.Legend.TextVisible = false;
			chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
			chartControl2.Location = new Point(477, 54);
			chartControl2.Name = "chartControl2";
			series1.Name = "Series 1";
			series1.SeriesID = 1;
			chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[]
	{
	series1
	};
			chartControl2.Size = new Size(475, 508);
			chartControl2.TabIndex = 6;
			chartTitle1.DXFont = new DevExpress.Drawing.DXFont("Microsoft YaHei UI", 18F, DevExpress.Drawing.DXFontStyle.Bold);
			chartTitle1.Text = "资产价值 Top 10 (百万元)";
			chartTitle1.TitleID = 0;
			chartControl2.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] { chartTitle1 });
			// 
			// chartControl1
			// 
			chartControl1.Location = new Point(14, 54);
			chartControl1.Name = "chartControl1";
			series2.Name = "Series 1";
			series2.SeriesID = 1;
			series2.View = pieSeriesView1;
			chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[]
	{
	series2
	};
			chartControl1.Size = new Size(459, 508);
			chartControl1.TabIndex = 5;
			chartTitle2.DXFont = new DevExpress.Drawing.DXFont("Microsoft YaHei UI", 18F, DevExpress.Drawing.DXFontStyle.Bold);
			chartTitle2.Text = "库存健康分布";
			chartTitle2.TitleID = 0;
			chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] { chartTitle2 });
			chartControl1.CustomDrawSeriesPoint += chartControl1_CustomDrawSeriesPoint;
			// 
			// panelControl4
			// 
			panelControl4.Controls.Add(labelControl4);
			panelControl4.Location = new Point(736, 14);
			panelControl4.Name = "panelControl4";
			panelControl4.Size = new Size(216, 36);
			panelControl4.TabIndex = 4;
			// 
			// labelControl4
			// 
			labelControl4.Appearance.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold);
			labelControl4.Appearance.ForeColor = Color.Red;
			labelControl4.Appearance.Options.UseFont = true;
			labelControl4.Appearance.Options.UseForeColor = true;
			labelControl4.Location = new Point(56, 10);
			labelControl4.Name = "labelControl4";
			labelControl4.Size = new Size(115, 24);
			labelControl4.TabIndex = 1;
			labelControl4.Text = "labelControl4";
			// 
			// panelControl3
			// 
			panelControl3.Controls.Add(labelControl3);
			panelControl3.Location = new Point(477, 14);
			panelControl3.Name = "panelControl3";
			panelControl3.Size = new Size(255, 36);
			panelControl3.TabIndex = 3;
			// 
			// labelControl3
			// 
			labelControl3.Appearance.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold);
			labelControl3.Appearance.ForeColor = Color.FromArgb(255, 128, 0);
			labelControl3.Appearance.Options.UseFont = true;
			labelControl3.Appearance.Options.UseForeColor = true;
			labelControl3.Location = new Point(84, 10);
			labelControl3.Name = "labelControl3";
			labelControl3.Size = new Size(114, 24);
			labelControl3.TabIndex = 1;
			labelControl3.Text = "labelControl3";
			// 
			// panelControl2
			// 
			panelControl2.Controls.Add(labelControl2);
			panelControl2.Location = new Point(228, 14);
			panelControl2.Name = "panelControl2";
			panelControl2.Size = new Size(245, 36);
			panelControl2.TabIndex = 2;
			// 
			// labelControl2
			// 
			labelControl2.Appearance.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold);
			labelControl2.Appearance.ForeColor = Color.FromArgb(64, 64, 64);
			labelControl2.Appearance.Options.UseFont = true;
			labelControl2.Appearance.Options.UseForeColor = true;
			labelControl2.Location = new Point(67, 10);
			labelControl2.Name = "labelControl2";
			labelControl2.Size = new Size(114, 24);
			labelControl2.TabIndex = 1;
			labelControl2.Text = "labelControl2";
			// 
			// panelControl1
			// 
			panelControl1.Controls.Add(labelControl1);
			panelControl1.Location = new Point(14, 14);
			panelControl1.Name = "panelControl1";
			panelControl1.Size = new Size(210, 36);
			panelControl1.TabIndex = 1;
			// 
			// labelControl1
			// 
			labelControl1.Appearance.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold);
			labelControl1.Appearance.ForeColor = Color.Black;
			labelControl1.Appearance.Options.UseFont = true;
			labelControl1.Appearance.Options.UseForeColor = true;
			labelControl1.LineColor = Color.Gray;
			labelControl1.Location = new Point(48, 10);
			labelControl1.Name = "labelControl1";
			labelControl1.Size = new Size(114, 24);
			labelControl1.TabIndex = 0;
			labelControl1.Text = "labelControl1";
			// 
			// Root
			// 
			Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			Root.GroupBordersVisible = false;
			Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6 });
			Root.Name = "Root";
			Root.Size = new Size(966, 576);
			Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			layoutControlItem1.Control = panelControl1;
			layoutControlItem1.Location = new Point(0, 0);
			layoutControlItem1.Name = "layoutControlItem1";
			layoutControlItem1.Size = new Size(214, 40);
			layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			layoutControlItem2.Control = panelControl2;
			layoutControlItem2.Location = new Point(214, 0);
			layoutControlItem2.Name = "layoutControlItem2";
			layoutControlItem2.Size = new Size(249, 40);
			layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			layoutControlItem3.Control = panelControl3;
			layoutControlItem3.Location = new Point(463, 0);
			layoutControlItem3.Name = "layoutControlItem3";
			layoutControlItem3.Size = new Size(259, 40);
			layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			layoutControlItem4.Control = panelControl4;
			layoutControlItem4.Location = new Point(722, 0);
			layoutControlItem4.Name = "layoutControlItem4";
			layoutControlItem4.Size = new Size(220, 40);
			layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			layoutControlItem5.Control = chartControl1;
			layoutControlItem5.Location = new Point(0, 40);
			layoutControlItem5.Name = "layoutControlItem5";
			layoutControlItem5.Size = new Size(463, 512);
			layoutControlItem5.TextVisible = false;
			// 
			// layoutControlItem6
			// 
			layoutControlItem6.Control = chartControl2;
			layoutControlItem6.Location = new Point(463, 40);
			layoutControlItem6.Name = "layoutControlItem6";
			layoutControlItem6.Size = new Size(479, 512);
			layoutControlItem6.TextVisible = false;
			// 
			// ucDashboard
			// 
			AutoScaleDimensions = new SizeF(7F, 16F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(layoutControl1);
			Name = "ucDashboard";
			Size = new Size(966, 576);
			Load += ucDashboard_Load;
			((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
			layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)xyDiagram1).EndInit();
			((System.ComponentModel.ISupportInitialize)series1).EndInit();
			((System.ComponentModel.ISupportInitialize)chartControl2).EndInit();
			((System.ComponentModel.ISupportInitialize)pieSeriesView1).EndInit();
			((System.ComponentModel.ISupportInitialize)series2).EndInit();
			((System.ComponentModel.ISupportInitialize)chartControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)panelControl4).EndInit();
			panelControl4.ResumeLayout(false);
			panelControl4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)panelControl3).EndInit();
			panelControl3.ResumeLayout(false);
			panelControl3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
			panelControl2.ResumeLayout(false);
			panelControl2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
			panelControl1.ResumeLayout(false);
			panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)Root).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.PanelControl panelControl4;
		private DevExpress.XtraEditors.PanelControl panelControl3;
		private DevExpress.XtraEditors.PanelControl panelControl2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraCharts.ChartControl chartControl2;
		private DevExpress.XtraCharts.ChartControl chartControl1;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
	}
}
