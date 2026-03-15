using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartInventory.Client
{
	public partial class FluentDesignForm1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
	{
		public FluentDesignForm1()
		{
			InitializeComponent();
		}

		private void accordionControlElement4_Click(object sender, EventArgs e)
		{
			//var document = tabbedView1.Documents.FirstOrDefault(x => x.Control is ucStockList);

			//if (document != null)
			//{
			//	tabbedView1.Controller.Activate(document);
			//}
			//else
			//{
			//	var myControl = new ucStockList();

			//	var newDoc = tabbedView1.AddDocument(myControl);
			//	newDoc.Caption = "库存列表";

			//	tabbedView1.Controller.Activate(newDoc);
			//}
			// Tools.OpenModule<ucStockList>("库存列表", tabbedView1);
			tabbedView1.OpenModule<ucStockList>("库存列表");
		}


		private void accordionControlElement3_Click(object sender, EventArgs e)
		{
			// Tools.OpenModule<sysControl>("系统设置", tabbedView1);
			tabbedView1.OpenModule<sysControl>("系统设置");

		}
	}
}
