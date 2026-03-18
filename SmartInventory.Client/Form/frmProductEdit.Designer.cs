namespace SmartInventory.Client.Form
{
	partial class frmProductEdit
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductEdit));
			dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			IdTextEdit = new DevExpress.XtraEditors.TextEdit();
			productBindingSource = new BindingSource(components);
			NameTextEdit = new DevExpress.XtraEditors.TextEdit();
			PriceTextEdit = new DevExpress.XtraEditors.TextEdit();
			StockTextEdit = new DevExpress.XtraEditors.TextEdit();
			Root = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			ItemForId = new DevExpress.XtraLayout.LayoutControlItem();
			ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
			ItemForPrice = new DevExpress.XtraLayout.LayoutControlItem();
			ItemForStock = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			productBindingSource1 = new BindingSource(components);
			((System.ComponentModel.ISupportInitialize)dataLayoutControl1).BeginInit();
			dataLayoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)IdTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)NameTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)PriceTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)StockTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)Root).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
			((System.ComponentModel.ISupportInitialize)ItemForId).BeginInit();
			((System.ComponentModel.ISupportInitialize)ItemForName).BeginInit();
			((System.ComponentModel.ISupportInitialize)ItemForPrice).BeginInit();
			((System.ComponentModel.ISupportInitialize)ItemForStock).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
			((System.ComponentModel.ISupportInitialize)productBindingSource1).BeginInit();
			SuspendLayout();
			// 
			// dataLayoutControl1
			// 
			dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.True;
			dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.True;
			dataLayoutControl1.Controls.Add(simpleButton2);
			dataLayoutControl1.Controls.Add(simpleButton1);
			dataLayoutControl1.Controls.Add(IdTextEdit);
			dataLayoutControl1.Controls.Add(NameTextEdit);
			dataLayoutControl1.Controls.Add(PriceTextEdit);
			dataLayoutControl1.Controls.Add(StockTextEdit);
			dataLayoutControl1.DataSource = productBindingSource;
			dataLayoutControl1.Dock = DockStyle.Fill;
			dataLayoutControl1.Location = new Point(0, 0);
			dataLayoutControl1.Name = "dataLayoutControl1";
			dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(546, 0, 812, 500);
			dataLayoutControl1.Root = Root;
			dataLayoutControl1.Size = new Size(863, 508);
			dataLayoutControl1.TabIndex = 0;
			dataLayoutControl1.Text = "dataLayoutControl1";
			// 
			// simpleButton2
			// 
			simpleButton2.ImageOptions.Image = (Image)resources.GetObject("simpleButton2.ImageOptions.Image");
			simpleButton2.Location = new Point(14, 118);
			simpleButton2.Name = "simpleButton2";
			simpleButton2.Size = new Size(415, 36);
			simpleButton2.StyleController = dataLayoutControl1;
			simpleButton2.TabIndex = 9;
			simpleButton2.Text = "保存";
			simpleButton2.Click += simpleButton2_Click;
			// 
			// simpleButton1
			// 
			simpleButton1.ImageOptions.Image = (Image)resources.GetObject("simpleButton1.ImageOptions.Image");
			simpleButton1.Location = new Point(433, 118);
			simpleButton1.Name = "simpleButton1";
			simpleButton1.Size = new Size(416, 36);
			simpleButton1.StyleController = dataLayoutControl1;
			simpleButton1.TabIndex = 8;
			simpleButton1.Text = "取消";
			simpleButton1.Click += simpleButton1_Click;
			// 
			// IdTextEdit
			// 
			IdTextEdit.DataBindings.Add(new Binding("EditValue", productBindingSource, "Id", true));
			IdTextEdit.Location = new Point(89, 14);
			IdTextEdit.Name = "IdTextEdit";
			IdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
			IdTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			IdTextEdit.Properties.MaskSettings.Set("mask", "N0");
			IdTextEdit.Properties.ReadOnly = true;
			IdTextEdit.Size = new Size(760, 22);
			IdTextEdit.StyleController = dataLayoutControl1;
			IdTextEdit.TabIndex = 4;
			// 
			// productBindingSource
			// 
			productBindingSource.DataSource = typeof(Models.Models.Product);
			// 
			// NameTextEdit
			// 
			NameTextEdit.DataBindings.Add(new Binding("EditValue", productBindingSource, "Name", true));
			NameTextEdit.Location = new Point(89, 40);
			NameTextEdit.Name = "NameTextEdit";
			NameTextEdit.Size = new Size(760, 22);
			NameTextEdit.StyleController = dataLayoutControl1;
			NameTextEdit.TabIndex = 5;
			// 
			// PriceTextEdit
			// 
			PriceTextEdit.DataBindings.Add(new Binding("EditValue", productBindingSource, "Price", true));
			PriceTextEdit.Location = new Point(89, 66);
			PriceTextEdit.Name = "PriceTextEdit";
			PriceTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			PriceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
			PriceTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			PriceTextEdit.Properties.MaskSettings.Set("mask", "G");
			PriceTextEdit.Size = new Size(760, 22);
			PriceTextEdit.StyleController = dataLayoutControl1;
			PriceTextEdit.TabIndex = 6;
			// 
			// StockTextEdit
			// 
			StockTextEdit.DataBindings.Add(new Binding("EditValue", productBindingSource, "Stock", true));
			StockTextEdit.Location = new Point(89, 92);
			StockTextEdit.Name = "StockTextEdit";
			StockTextEdit.Size = new Size(760, 22);
			StockTextEdit.StyleController = dataLayoutControl1;
			StockTextEdit.TabIndex = 7;
			// 
			// Root
			// 
			Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			Root.GroupBordersVisible = false;
			Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroup1, layoutControlItem1, layoutControlItem2 });
			Root.Name = "Root";
			Root.Size = new Size(863, 508);
			Root.TextVisible = false;
			// 
			// layoutControlGroup1
			// 
			layoutControlGroup1.AllowDrawBackground = false;
			layoutControlGroup1.GroupBordersVisible = false;
			layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { ItemForId, ItemForName, ItemForPrice, ItemForStock });
			layoutControlGroup1.Location = new Point(0, 0);
			layoutControlGroup1.Name = "autoGeneratedGroup0";
			layoutControlGroup1.Size = new Size(839, 104);
			// 
			// ItemForId
			// 
			ItemForId.Control = IdTextEdit;
			ItemForId.Location = new Point(0, 0);
			ItemForId.Name = "ItemForId";
			ItemForId.Size = new Size(839, 26);
			ItemForId.Text = "Id";
			ItemForId.TextSize = new Size(60, 16);
			// 
			// ItemForName
			// 
			ItemForName.Control = NameTextEdit;
			ItemForName.Location = new Point(0, 26);
			ItemForName.Name = "ItemForName";
			ItemForName.Size = new Size(839, 26);
			ItemForName.Text = "产品名称";
			ItemForName.TextLocation = DevExpress.Utils.Locations.Left;
			ItemForName.TextSize = new Size(60, 16);
			// 
			// ItemForPrice
			// 
			ItemForPrice.Control = PriceTextEdit;
			ItemForPrice.Location = new Point(0, 52);
			ItemForPrice.Name = "ItemForPrice";
			ItemForPrice.Size = new Size(839, 26);
			ItemForPrice.Text = "价格";
			ItemForPrice.TextSize = new Size(60, 16);
			// 
			// ItemForStock
			// 
			ItemForStock.Control = StockTextEdit;
			ItemForStock.Location = new Point(0, 78);
			ItemForStock.Name = "ItemForStock";
			ItemForStock.Size = new Size(839, 26);
			ItemForStock.Text = "库存";
			ItemForStock.TextSize = new Size(60, 16);
			// 
			// layoutControlItem1
			// 
			layoutControlItem1.Control = simpleButton1;
			layoutControlItem1.Location = new Point(419, 104);
			layoutControlItem1.Name = "layoutControlItem1";
			layoutControlItem1.Size = new Size(420, 380);
			layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			layoutControlItem2.Control = simpleButton2;
			layoutControlItem2.Location = new Point(0, 104);
			layoutControlItem2.Name = "layoutControlItem2";
			layoutControlItem2.Size = new Size(419, 380);
			layoutControlItem2.TextVisible = false;
			// 
			// productBindingSource1
			// 
			productBindingSource1.DataSource = typeof(Models.Models.Product);
			// 
			// frmProductEdit
			// 
			AutoScaleDimensions = new SizeF(7F, 16F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(863, 508);
			Controls.Add(dataLayoutControl1);
			Name = "frmProductEdit";
			Text = "库存管理";
			((System.ComponentModel.ISupportInitialize)dataLayoutControl1).EndInit();
			dataLayoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)IdTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)NameTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)PriceTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)StockTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)Root).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
			((System.ComponentModel.ISupportInitialize)ItemForId).EndInit();
			((System.ComponentModel.ISupportInitialize)ItemForName).EndInit();
			((System.ComponentModel.ISupportInitialize)ItemForPrice).EndInit();
			((System.ComponentModel.ISupportInitialize)ItemForStock).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
			((System.ComponentModel.ISupportInitialize)productBindingSource1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private BindingSource productBindingSource;
		private DevExpress.XtraEditors.TextEdit IdTextEdit;
		private DevExpress.XtraEditors.TextEdit NameTextEdit;
		private DevExpress.XtraEditors.TextEdit PriceTextEdit;
		private DevExpress.XtraEditors.TextEdit StockTextEdit;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem ItemForId;
		private DevExpress.XtraLayout.LayoutControlItem ItemForName;
		private DevExpress.XtraLayout.LayoutControlItem ItemForPrice;
		private DevExpress.XtraLayout.LayoutControlItem ItemForStock;
		private BindingSource productBindingSource1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
	}
}