using DevExpress.XtraEditors;
using Newtonsoft.Json;
using SmartInventory.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SmartInventory.Client.Tools;

namespace SmartInventory.Client.Form
{
	public partial class frmProductEdit : DevExpress.XtraEditors.XtraForm
	{
		private Product _product = null;
		public frmProductEdit()
		{
			InitializeComponent();
		}

		public frmProductEdit(Product product)
		{
			InitializeComponent();

			this._product = product;
			dataLayoutControl1.DataSource = this._product;
			dataLayoutControl1.Refresh();
		}

		private async void simpleButton2_Click(object sender, EventArgs e)
		{
			try
			{
				simpleButton2.Enabled = false;
				dataLayoutControl1.Validate();

				HttpResponseMessage rep = null;
				if (_product.Id == 0)
				{
					rep = await HttpHelper.PostAsync($"api/Product/", _product);
				}
				else
				{
					rep = await HttpHelper.PutAsync($"api/Product/{_product.Id}", _product);
				}

				if (rep.IsSuccessStatusCode)
				{
					XtraMessageBox.Show("保存成功");
					this.DialogResult = DialogResult.OK;
				}
				else
				{
					XtraMessageBox.Show("保存失败", rep.ReasonPhrase);
				}
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show("请联系管理员", ex.ToString());
			}
			finally
			{
				simpleButton1.Enabled = true;
			}
			

			this.Close();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}