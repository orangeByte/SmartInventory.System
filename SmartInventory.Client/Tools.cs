using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
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
	static class Tools
	{
		public static void OpenModule<T>(this TabbedView tabbedView, string caption) where T : UserControl, new()
		{
			var document = tabbedView.Documents.FirstOrDefault(x => x.Control is T);
			if (document != null)
			{
				tabbedView.Controller.Activate(document);
			}
			else
			{
				T control = new() { Name = typeof(T).Name};
				var newdoc = tabbedView.AddDocument(control);
				newdoc.Caption = caption;
				tabbedView.Controller.Activate(newdoc);

			}
		}
	}

	
}
