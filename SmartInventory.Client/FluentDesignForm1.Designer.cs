namespace SmartInventory.Client
{
	partial class FluentDesignForm1
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
			fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
			accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
			accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
			barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
			documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(components);
			tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(components);
			((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)documentManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)tabbedView1).BeginInit();
			SuspendLayout();
			// 
			// fluentDesignFormContainer1
			// 
			fluentDesignFormContainer1.Dock = DockStyle.Fill;
			fluentDesignFormContainer1.Location = new Point(269, 37);
			fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
			fluentDesignFormContainer1.Size = new Size(765, 577);
			fluentDesignFormContainer1.TabIndex = 0;
			// 
			// accordionControl1
			// 
			accordionControl1.Dock = DockStyle.Left;
			accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement1, accordionControlElement2 });
			accordionControl1.Location = new Point(0, 37);
			accordionControl1.Name = "accordionControl1";
			accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
			accordionControl1.Size = new Size(269, 577);
			accordionControl1.TabIndex = 1;
			accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
			// 
			// accordionControlElement1
			// 
			accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement4 });
			accordionControlElement1.Expanded = true;
			accordionControlElement1.Name = "accordionControlElement1";
			accordionControlElement1.Text = "库存";
			// 
			// accordionControlElement4
			// 
			accordionControlElement4.Name = "accordionControlElement4";
			accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			accordionControlElement4.Text = "库存查看";
			accordionControlElement4.Click += accordionControlElement4_Click;
			// 
			// accordionControlElement2
			// 
			accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement3 });
			accordionControlElement2.Expanded = true;
			accordionControlElement2.Name = "accordionControlElement2";
			accordionControlElement2.Text = "系统";
			// 
			// accordionControlElement3
			// 
			accordionControlElement3.Name = "accordionControlElement3";
			accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			accordionControlElement3.Text = "系统设置";
			accordionControlElement3.Click += accordionControlElement3_Click;
			// 
			// fluentDesignFormControl1
			// 
			fluentDesignFormControl1.FluentDesignForm = this;
			fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItem1 });
			fluentDesignFormControl1.Location = new Point(0, 0);
			fluentDesignFormControl1.Manager = fluentFormDefaultManager1;
			fluentDesignFormControl1.Name = "fluentDesignFormControl1";
			fluentDesignFormControl1.Size = new Size(1034, 37);
			fluentDesignFormControl1.TabIndex = 2;
			fluentDesignFormControl1.TabStop = false;
			// 
			// barButtonItem1
			// 
			barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			barButtonItem1.Caption = "barButtonItem1";
			barButtonItem1.Id = 0;
			barButtonItem1.Name = "barButtonItem1";
			// 
			// fluentFormDefaultManager1
			// 
			fluentFormDefaultManager1.Form = this;
			fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItem1 });
			fluentFormDefaultManager1.MaxItemId = 1;
			// 
			// documentManager1
			// 
			documentManager1.ContainerControl = this;
			documentManager1.MenuManager = fluentFormDefaultManager1;
			documentManager1.View = tabbedView1;
			documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] { tabbedView1 });
			// 
			// FluentDesignForm1
			// 
			AutoScaleDimensions = new SizeF(7F, 16F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1034, 614);
			ControlContainer = fluentDesignFormContainer1;
			Controls.Add(fluentDesignFormContainer1);
			Controls.Add(accordionControl1);
			Controls.Add(fluentDesignFormControl1);
			FluentDesignFormControl = fluentDesignFormControl1;
			Name = "FluentDesignForm1";
			NavigationControl = accordionControl1;
			Text = "FluentDesignForm1";
			((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)documentManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)tabbedView1).EndInit();
			ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
		private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
		private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
		private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
	}
}