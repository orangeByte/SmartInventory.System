namespace SmartInventory.Client.Form
{
	partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			textEdit1 = new DevExpress.XtraEditors.TextEdit();
			textEdit2 = new DevExpress.XtraEditors.TextEdit();
			labelControl1 = new DevExpress.XtraEditors.LabelControl();
			labelControl2 = new DevExpress.XtraEditors.LabelControl();
			simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
			SuspendLayout();
			// 
			// textEdit1
			// 
			textEdit1.Location = new Point(342, 147);
			textEdit1.Name = "textEdit1";
			textEdit1.Size = new Size(156, 22);
			textEdit1.TabIndex = 0;
			// 
			// textEdit2
			// 
			textEdit2.Location = new Point(342, 215);
			textEdit2.Name = "textEdit2";
			textEdit2.Properties.PasswordChar = '*';
			textEdit2.Size = new Size(156, 22);
			textEdit2.TabIndex = 1;
			// 
			// labelControl1
			// 
			labelControl1.Location = new Point(291, 150);
			labelControl1.Name = "labelControl1";
			labelControl1.Size = new Size(45, 16);
			labelControl1.TabIndex = 2;
			labelControl1.Text = "用户名";
			// 
			// labelControl2
			// 
			labelControl2.Location = new Point(306, 218);
			labelControl2.Name = "labelControl2";
			labelControl2.Size = new Size(30, 16);
			labelControl2.TabIndex = 3;
			labelControl2.Text = "密码";
			// 
			// simpleButton1
			// 
			simpleButton1.ImageOptions.Image = (Image)resources.GetObject("simpleButton1.ImageOptions.Image");
			simpleButton1.Location = new Point(342, 262);
			simpleButton1.Name = "simpleButton1";
			simpleButton1.Size = new Size(74, 36);
			simpleButton1.TabIndex = 4;
			simpleButton1.Text = "登入";
			simpleButton1.Click += simpleButton1_Click;
			// 
			// simpleButton2
			// 
			simpleButton2.ImageOptions.Image = (Image)resources.GetObject("simpleButton2.ImageOptions.Image");
			simpleButton2.Location = new Point(422, 262);
			simpleButton2.Name = "simpleButton2";
			simpleButton2.Size = new Size(76, 36);
			simpleButton2.TabIndex = 5;
			simpleButton2.Text = "取消";
			simpleButton2.Click += simpleButton2_Click;
			// 
			// frmLogin
			// 
			AutoScaleDimensions = new SizeF(7F, 16F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImageLayoutStore = ImageLayout.Stretch;
			BackgroundImageStore = Properties.Resources.background;
			ClientSize = new Size(832, 478);
			Controls.Add(simpleButton2);
			Controls.Add(simpleButton1);
			Controls.Add(labelControl2);
			Controls.Add(labelControl1);
			Controls.Add(textEdit2);
			Controls.Add(textEdit1);
			DoubleBuffered = true;
			Name = "frmLogin";
			Text = "登陆";
			((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraEditors.TextEdit textEdit1;
		private DevExpress.XtraEditors.TextEdit textEdit2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
	}
}