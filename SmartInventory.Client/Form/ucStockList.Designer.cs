namespace SmartInventory.Client
{
	partial class ucStockList
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
			components = new System.ComponentModel.Container();
			DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue3 = new DevExpress.XtraEditors.FormatConditionRuleValue();
			DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue4 = new DevExpress.XtraEditors.FormatConditionRuleValue();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStockList));
			colStock = new DevExpress.XtraGrid.Columns.GridColumn();
			gridControl1 = new DevExpress.XtraGrid.GridControl();
			productBindingSource = new BindingSource(components);
			gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			colId = new DevExpress.XtraGrid.Columns.GridColumn();
			colName = new DevExpress.XtraGrid.Columns.GridColumn();
			colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
			simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
			SuspendLayout();
			// 
			// colStock
			// 
			colStock.Caption = "库存";
			colStock.FieldName = "Stock";
			colStock.MinWidth = 25;
			colStock.Name = "colStock";
			colStock.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Max, "Stock", "MAX={0}") });
			colStock.Visible = true;
			colStock.VisibleIndex = 2;
			colStock.Width = 94;
			// 
			// gridControl1
			// 
			gridControl1.DataSource = productBindingSource;
			gridControl1.Dock = DockStyle.Fill;
			gridControl1.Location = new Point(0, 0);
			gridControl1.MainView = gridView1;
			gridControl1.Name = "gridControl1";
			gridControl1.RightToLeft = RightToLeft.No;
			gridControl1.Size = new Size(825, 546);
			gridControl1.TabIndex = 0;
			gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
			gridControl1.Load += gridControl1_Load;
			// 
			// productBindingSource
			// 
			productBindingSource.DataSource = typeof(Models.Models.Product);
			// 
			// gridView1
			// 
			gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colName, colPrice, colStock });
			gridFormatRule3.ApplyToRow = true;
			gridFormatRule3.Column = colStock;
			gridFormatRule3.Name = "Format0";
			formatConditionRuleValue3.Appearance.BackColor = Color.OrangeRed;
			formatConditionRuleValue3.Appearance.Options.UseBackColor = true;
			formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Expression;
			formatConditionRuleValue3.Expression = "[Stock] < 300 And [Stock] > 100";
			gridFormatRule3.Rule = formatConditionRuleValue3;
			gridFormatRule4.ApplyToRow = true;
			gridFormatRule4.Column = colStock;
			gridFormatRule4.Name = "Format1";
			formatConditionRuleValue4.Appearance.BackColor = Color.Red;
			formatConditionRuleValue4.Appearance.Options.UseBackColor = true;
			formatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Expression;
			formatConditionRuleValue4.Expression = "[Stock] <= 100";
			gridFormatRule4.Rule = formatConditionRuleValue4;
			gridView1.FormatRules.Add(gridFormatRule3);
			gridView1.FormatRules.Add(gridFormatRule4);
			gridView1.GridControl = gridControl1;
			gridView1.Name = "gridView1";
			gridView1.OptionsView.ShowFooter = true;
			gridView1.DoubleClick += gridView1_DoubleClick;
			// 
			// colId
			// 
			colId.FieldName = "Id";
			colId.MinWidth = 25;
			colId.Name = "colId";
			colId.Width = 94;
			// 
			// colName
			// 
			colName.Caption = "产品名称";
			colName.FieldName = "Name";
			colName.MinWidth = 25;
			colName.Name = "colName";
			colName.Visible = true;
			colName.VisibleIndex = 0;
			colName.Width = 94;
			// 
			// colPrice
			// 
			colPrice.Caption = "产品价格";
			colPrice.FieldName = "Price";
			colPrice.MinWidth = 25;
			colPrice.Name = "colPrice";
			colPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "Price", "AVG={0:0.##}") });
			colPrice.Visible = true;
			colPrice.VisibleIndex = 1;
			colPrice.Width = 94;
			// 
			// simpleButton1
			// 
			simpleButton1.ImageOptions.Image = (Image)resources.GetObject("simpleButton1.ImageOptions.Image");
			simpleButton1.Location = new Point(569, 3);
			simpleButton1.Name = "simpleButton1";
			simpleButton1.Size = new Size(118, 36);
			simpleButton1.TabIndex = 1;
			simpleButton1.Text = "导出";
			simpleButton1.Click += simpleButton1_Click;
			// 
			// simpleButton2
			// 
			simpleButton2.ImageOptions.Image = (Image)resources.GetObject("simpleButton2.ImageOptions.Image");
			simpleButton2.Location = new Point(321, 3);
			simpleButton2.Name = "simpleButton2";
			simpleButton2.Size = new Size(118, 36);
			simpleButton2.TabIndex = 2;
			simpleButton2.Text = "新增";
			simpleButton2.Click += simpleButton2_Click;
			// 
			// simpleButton3
			// 
			simpleButton3.ImageOptions.Image = (Image)resources.GetObject("simpleButton3.ImageOptions.Image");
			simpleButton3.Location = new Point(445, 3);
			simpleButton3.Name = "simpleButton3";
			simpleButton3.Size = new Size(118, 36);
			simpleButton3.TabIndex = 3;
			simpleButton3.Text = "删除";
			simpleButton3.Click += simpleButton3_Click;
			// 
			// ucStockList
			// 
			AutoScaleDimensions = new SizeF(7F, 16F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(simpleButton3);
			Controls.Add(simpleButton2);
			Controls.Add(simpleButton1);
			Controls.Add(gridControl1);
			Name = "ucStockList";
			Size = new Size(825, 546);
			((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private BindingSource productBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colName;
		private DevExpress.XtraGrid.Columns.GridColumn colPrice;
		private DevExpress.XtraGrid.Columns.GridColumn colStock;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraEditors.SimpleButton simpleButton3;
	}
}
