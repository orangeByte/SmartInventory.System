namespace SmartInventory.Client.Form
{
	partial class ucHardwareCenter
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHardwareCenter));
			layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			gridControl1 = new DevExpress.XtraGrid.GridControl();
			gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
			simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
			Root = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
			layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
			layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)Root).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
			((System.ComponentModel.ISupportInitialize)simpleLabelItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
			SuspendLayout();
			// 
			// layoutControl1
			// 
			layoutControl1.Controls.Add(gridControl1);
			layoutControl1.Controls.Add(comboBoxEdit1);
			layoutControl1.Controls.Add(simpleButton1);
			layoutControl1.Controls.Add(simpleButton2);
			layoutControl1.Controls.Add(memoEdit1);
			layoutControl1.Dock = DockStyle.Fill;
			layoutControl1.Location = new Point(0, 0);
			layoutControl1.Name = "layoutControl1";
			layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(986, 228, 812, 500);
			layoutControl1.Root = Root;
			layoutControl1.Size = new Size(926, 559);
			layoutControl1.TabIndex = 0;
			layoutControl1.Text = "layoutControl1";
			// 
			// gridControl1
			// 
			gridControl1.Location = new Point(14, 54);
			gridControl1.MainView = gridView1;
			gridControl1.Name = "gridControl1";
			gridControl1.Size = new Size(898, 363);
			gridControl1.TabIndex = 5;
			gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
			// 
			// gridView1
			// 
			gridView1.GridControl = gridControl1;
			gridView1.Name = "gridView1";
			// 
			// comboBoxEdit1
			// 
			comboBoxEdit1.EditValue = "";
			comboBoxEdit1.Location = new Point(94, 14);
			comboBoxEdit1.Name = "comboBoxEdit1";
			comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			comboBoxEdit1.Size = new Size(141, 22);
			comboBoxEdit1.StyleController = layoutControl1;
			comboBoxEdit1.TabIndex = 0;
			// 
			// simpleButton1
			// 
			simpleButton1.ImageOptions.Image = (Image)resources.GetObject("simpleButton1.ImageOptions.Image");
			simpleButton1.Location = new Point(239, 14);
			simpleButton1.Name = "simpleButton1";
			simpleButton1.Size = new Size(222, 36);
			simpleButton1.StyleController = layoutControl1;
			simpleButton1.TabIndex = 2;
			simpleButton1.Text = "连接";
			simpleButton1.Click += simpleButton1_Click;
			// 
			// simpleButton2
			// 
			simpleButton2.ImageOptions.Image = (Image)resources.GetObject("simpleButton2.ImageOptions.Image");
			simpleButton2.Location = new Point(465, 14);
			simpleButton2.Name = "simpleButton2";
			simpleButton2.Size = new Size(221, 36);
			simpleButton2.StyleController = layoutControl1;
			simpleButton2.TabIndex = 3;
			simpleButton2.Text = "断开";
			simpleButton2.Click += simpleButton2_Click;
			// 
			// memoEdit1
			// 
			memoEdit1.Location = new Point(94, 421);
			memoEdit1.Name = "memoEdit1";
			memoEdit1.Size = new Size(818, 124);
			memoEdit1.StyleController = layoutControl1;
			memoEdit1.TabIndex = 4;
			// 
			// Root
			// 
			Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			Root.GroupBordersVisible = false;
			Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, simpleLabelItem1, layoutControlItem4, layoutControlItem5 });
			Root.Name = "Root";
			Root.Size = new Size(926, 559);
			Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			layoutControlItem1.Control = comboBoxEdit1;
			layoutControlItem1.CustomizationFormText = "串口选择:";
			layoutControlItem1.Location = new Point(0, 0);
			layoutControlItem1.Name = "layoutControlItem1";
			layoutControlItem1.Size = new Size(225, 40);
			layoutControlItem1.Text = "串口选择:";
			layoutControlItem1.TextSize = new Size(65, 16);
			// 
			// layoutControlItem2
			// 
			layoutControlItem2.Control = simpleButton1;
			layoutControlItem2.Location = new Point(225, 0);
			layoutControlItem2.Name = "layoutControlItem2";
			layoutControlItem2.Size = new Size(226, 40);
			layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			layoutControlItem3.Control = simpleButton2;
			layoutControlItem3.Location = new Point(451, 0);
			layoutControlItem3.Name = "layoutControlItem3";
			layoutControlItem3.Size = new Size(225, 40);
			layoutControlItem3.TextVisible = false;
			// 
			// simpleLabelItem1
			// 
			simpleLabelItem1.Location = new Point(676, 0);
			simpleLabelItem1.Name = "simpleLabelItem1";
			simpleLabelItem1.Size = new Size(226, 40);
			simpleLabelItem1.Text = "状态:";
			simpleLabelItem1.TextSize = new Size(65, 16);
			// 
			// layoutControlItem4
			// 
			layoutControlItem4.Control = memoEdit1;
			layoutControlItem4.Location = new Point(0, 407);
			layoutControlItem4.Name = "layoutControlItem4";
			layoutControlItem4.Size = new Size(902, 128);
			layoutControlItem4.Text = "原始数据";
			layoutControlItem4.TextSize = new Size(65, 16);
			// 
			// layoutControlItem5
			// 
			layoutControlItem5.Control = gridControl1;
			layoutControlItem5.Location = new Point(0, 40);
			layoutControlItem5.Name = "layoutControlItem5";
			layoutControlItem5.Size = new Size(902, 367);
			layoutControlItem5.TextVisible = false;
			// 
			// ucHardwareCenter
			// 
			AutoScaleDimensions = new SizeF(7F, 16F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(layoutControl1);
			Name = "ucHardwareCenter";
			Size = new Size(926, 559);
			Load += ucHardwareCenter_Load_1;
			((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
			layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)Root).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
			((System.ComponentModel.ISupportInitialize)simpleLabelItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
		private DevExpress.XtraEditors.MemoEdit memoEdit1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
	}
}
