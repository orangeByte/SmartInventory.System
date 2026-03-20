using DevExpress.XtraBars;
using DevExpress.XtraEditors.Filtering.Templates;
using SmartInventory.Client.Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static SmartInventory.Client.Tools;

namespace SmartInventory.Client
{
	public partial class FluentDesignForm1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
	{
		public FluentDesignForm1()
		{
			InitializeComponent();

			var username = GetCurUsername();
			var role = GetCurRole();

			barStaticItem1.Caption = "状态: 系统正常";
			barStaticItem2.Caption = $"用户: {username}";
			barStaticItem3.Caption = $"权限: {role}";
			barStaticItem4.Caption = $"时间: {DateTime.Now}";


		}

		private void accordionControlElement4_Click(object sender, EventArgs e)
		{
			tabbedView1.OpenModule<ucStockList>("库存列表");
		}


		private void accordionControlElement3_Click(object sender, EventArgs e)
		{
			tabbedView1.OpenModule<sysControl>("系统设置");

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			barStaticItem4.Caption = $"时间: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
		}

		private void accordionControlElement6_Click(object sender, EventArgs e)
		{
			tabbedView1.OpenModule<ucDashboard>("库存看板");

		}
	}
}
