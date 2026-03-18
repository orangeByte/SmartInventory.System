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
			DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
			DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStockList));
			colStock = new DevExpress.XtraGrid.Columns.GridColumn();
			gridControl1 = new DevExpress.XtraGrid.GridControl();
			productBindingSource = new BindingSource(components);
			gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			colId = new DevExpress.XtraGrid.Columns.GridColumn();
			colName = new DevExpress.XtraGrid.Columns.GridColumn();
			colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
			simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
			label1 = new Label();
			simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
			simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
			layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
			Root = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
			emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
			emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
			layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)tabbedControlGroup1).BeginInit();
			((System.ComponentModel.ISupportInitialize)Root).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem4).BeginInit();
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
			gridControl1.Location = new Point(14, 54);
			gridControl1.MainView = gridView1;
			gridControl1.Name = "gridControl1";
			gridControl1.RightToLeft = RightToLeft.No;
			gridControl1.Size = new Size(797, 438);
			gridControl1.TabIndex = 4;
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
			gridFormatRule1.ApplyToRow = true;
			gridFormatRule1.Column = colStock;
			gridFormatRule1.Name = "Format0";
			formatConditionRuleValue1.Appearance.BackColor = Color.OrangeRed;
			formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
			formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Expression;
			formatConditionRuleValue1.Expression = "[Stock] < 300 And [Stock] > 100";
			gridFormatRule1.Rule = formatConditionRuleValue1;
			gridFormatRule2.ApplyToRow = true;
			gridFormatRule2.Column = colStock;
			gridFormatRule2.Name = "Format1";
			formatConditionRuleValue2.Appearance.BackColor = Color.Red;
			formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
			formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Expression;
			formatConditionRuleValue2.Expression = "[Stock] <= 100";
			gridFormatRule2.Rule = formatConditionRuleValue2;
			gridView1.FormatRules.Add(gridFormatRule1);
			gridView1.FormatRules.Add(gridFormatRule2);
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
			simpleButton1.Location = new Point(552, 14);
			simpleButton1.Name = "simpleButton1";
			simpleButton1.Size = new Size(259, 36);
			simpleButton1.StyleController = layoutControl1;
			simpleButton1.TabIndex = 3;
			simpleButton1.Text = "导出";
			simpleButton1.Click += simpleButton1_Click;
			// 
			// layoutControl1
			// 
			layoutControl1.Controls.Add(simpleButton5);
			layoutControl1.Controls.Add(label1);
			layoutControl1.Controls.Add(simpleButton4);
			layoutControl1.Controls.Add(simpleButton2);
			layoutControl1.Controls.Add(simpleButton3);
			layoutControl1.Controls.Add(simpleButton1);
			layoutControl1.Controls.Add(gridControl1);
			layoutControl1.Dock = DockStyle.Fill;
			layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroup1, tabbedControlGroup1 });
			layoutControl1.Location = new Point(0, 0);
			layoutControl1.Name = "layoutControl1";
			layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(996, 256, 812, 500);
			layoutControl1.Root = Root;
			layoutControl1.Size = new Size(825, 546);
			layoutControl1.TabIndex = 5;
			layoutControl1.Text = "layoutControl1";
			// 
			// simpleButton5
			// 
			simpleButton5.ImageOptions.Image = (Image)resources.GetObject("simpleButton5.ImageOptions.Image");
			simpleButton5.Location = new Point(563, 496);
			simpleButton5.Name = "simpleButton5";
			simpleButton5.Size = new Size(248, 36);
			simpleButton5.StyleController = layoutControl1;
			simpleButton5.TabIndex = 6;
			simpleButton5.Text = "下一页";
			simpleButton5.Click += simpleButton5_Click;
			// 
			// label1
			// 
			label1.Location = new Point(365, 507);
			label1.Name = "label1";
			label1.Size = new Size(75, 25);
			label1.TabIndex = 1;
			label1.Text = "label1";
			// 
			// simpleButton4
			// 
			simpleButton4.ImageOptions.Image = (Image)resources.GetObject("simpleButton4.ImageOptions.Image");
			simpleButton4.Location = new Point(14, 496);
			simpleButton4.Name = "simpleButton4";
			simpleButton4.Size = new Size(243, 36);
			simpleButton4.StyleController = layoutControl1;
			simpleButton4.TabIndex = 5;
			simpleButton4.Text = "上一页";
			simpleButton4.Click += simpleButton4_Click;
			// 
			// simpleButton2
			// 
			simpleButton2.ImageOptions.Image = (Image)resources.GetObject("simpleButton2.ImageOptions.Image");
			simpleButton2.Location = new Point(14, 14);
			simpleButton2.Name = "simpleButton2";
			simpleButton2.Size = new Size(243, 36);
			simpleButton2.StyleController = layoutControl1;
			simpleButton2.TabIndex = 0;
			simpleButton2.Text = "新增";
			simpleButton2.Click += simpleButton2_Click;
			// 
			// simpleButton3
			// 
			simpleButton3.ImageOptions.Image = (Image)resources.GetObject("simpleButton3.ImageOptions.Image");
			simpleButton3.Location = new Point(261, 14);
			simpleButton3.Name = "simpleButton3";
			simpleButton3.Size = new Size(287, 36);
			simpleButton3.StyleController = layoutControl1;
			simpleButton3.TabIndex = 2;
			simpleButton3.Text = "删除";
			simpleButton3.Click += simpleButton3_Click;
			// 
			// layoutControlGroup1
			// 
			layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { emptySpaceItem1 });
			layoutControlGroup1.Location = new Point(0, 0);
			layoutControlGroup1.Name = "layoutControlGroup1";
			layoutControlGroup1.Size = new Size(773, 10);
			// 
			// emptySpaceItem1
			// 
			emptySpaceItem1.Location = new Point(0, 0);
			emptySpaceItem1.Name = "emptySpaceItem1";
			emptySpaceItem1.Size = new Size(773, 10);
			// 
			// tabbedControlGroup1
			// 
			tabbedControlGroup1.Location = new Point(0, 452);
			tabbedControlGroup1.Name = "tabbedControlGroup1";
			tabbedControlGroup1.SelectedTabPage = null;
			tabbedControlGroup1.Size = new Size(801, 70);
			// 
			// Root
			// 
			Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			Root.GroupBordersVisible = false;
			Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem4, layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem6, layoutControlItem7, layoutControlItem8, emptySpaceItem2, emptySpaceItem3, emptySpaceItem4 });
			Root.Name = "Root";
			Root.Size = new Size(825, 546);
			Root.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			layoutControlItem4.Control = simpleButton2;
			layoutControlItem4.Location = new Point(0, 0);
			layoutControlItem4.Name = "layoutControlItem4";
			layoutControlItem4.Size = new Size(247, 40);
			layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			layoutControlItem1.Control = gridControl1;
			layoutControlItem1.Location = new Point(0, 40);
			layoutControlItem1.Name = "layoutControlItem1";
			layoutControlItem1.Size = new Size(801, 442);
			layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			layoutControlItem2.Control = simpleButton3;
			layoutControlItem2.Location = new Point(247, 0);
			layoutControlItem2.Name = "layoutControlItem2";
			layoutControlItem2.Size = new Size(291, 40);
			layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			layoutControlItem3.Control = simpleButton1;
			layoutControlItem3.Location = new Point(538, 0);
			layoutControlItem3.Name = "layoutControlItem3";
			layoutControlItem3.Size = new Size(263, 40);
			layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem6
			// 
			layoutControlItem6.Control = simpleButton4;
			layoutControlItem6.Location = new Point(0, 482);
			layoutControlItem6.Name = "layoutControlItem6";
			layoutControlItem6.Size = new Size(247, 40);
			layoutControlItem6.TextVisible = false;
			// 
			// layoutControlItem7
			// 
			layoutControlItem7.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
			layoutControlItem7.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
			layoutControlItem7.Control = label1;
			layoutControlItem7.Location = new Point(351, 493);
			layoutControlItem7.Name = "layoutControlItem7";
			layoutControlItem7.Size = new Size(79, 29);
			layoutControlItem7.TextVisible = false;
			// 
			// layoutControlItem8
			// 
			layoutControlItem8.Control = simpleButton5;
			layoutControlItem8.Location = new Point(549, 482);
			layoutControlItem8.Name = "layoutControlItem8";
			layoutControlItem8.Size = new Size(252, 40);
			layoutControlItem8.TextVisible = false;
			// 
			// emptySpaceItem2
			// 
			emptySpaceItem2.Location = new Point(247, 482);
			emptySpaceItem2.Name = "emptySpaceItem2";
			emptySpaceItem2.Size = new Size(104, 40);
			// 
			// emptySpaceItem3
			// 
			emptySpaceItem3.Location = new Point(430, 482);
			emptySpaceItem3.Name = "emptySpaceItem3";
			emptySpaceItem3.Size = new Size(119, 40);
			// 
			// emptySpaceItem4
			// 
			emptySpaceItem4.Location = new Point(351, 482);
			emptySpaceItem4.Name = "emptySpaceItem4";
			emptySpaceItem4.Size = new Size(79, 11);
			// 
			// ucStockList
			// 
			AutoScaleDimensions = new SizeF(7F, 16F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(layoutControl1);
			Name = "ucStockList";
			Size = new Size(825, 546);
			((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
			layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)tabbedControlGroup1).EndInit();
			((System.ComponentModel.ISupportInitialize)Root).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem4).EndInit();
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
		private DevExpress.XtraEditors.SimpleButton simpleButton4;
		private DevExpress.XtraEditors.SimpleButton simpleButton5;
		private Label label1;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
	}
}
