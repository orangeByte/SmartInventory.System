namespace SmartInventory.Client
{
	partial class sysControl
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
			gridControl1 = new DevExpress.XtraGrid.GridControl();
			gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
			SuspendLayout();
			// 
			// gridControl1
			// 
			gridControl1.Dock = DockStyle.Fill;
			gridControl1.Location = new Point(0, 0);
			gridControl1.MainView = gridView1;
			gridControl1.Name = "gridControl1";
			gridControl1.Size = new Size(813, 481);
			gridControl1.TabIndex = 0;
			gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
			gridControl1.Click += gridControl1_Click;
			// 
			// gridView1
			// 
			gridView1.GridControl = gridControl1;
			gridView1.Name = "gridView1";
			// 
			// simpleButton1
			// 
			simpleButton1.Location = new Point(319, 3);
			simpleButton1.Name = "simpleButton1";
			simpleButton1.Size = new Size(118, 36);
			simpleButton1.TabIndex = 1;
			simpleButton1.Text = "系统";
			// 
			// sysControl
			// 
			AutoScaleDimensions = new SizeF(7F, 16F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(simpleButton1);
			Controls.Add(gridControl1);
			Name = "sysControl";
			Size = new Size(813, 481);
			((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
	}
}
