using SmartInventory.Client.Form;
using System.Windows.Forms;

namespace SmartInventory.Client
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

			using frmLogin frmLogin = new();

			frmLogin.StartPosition = FormStartPosition.CenterParent;

			if (frmLogin.ShowDialog() == DialogResult.OK)
			{
				Application.Run(new FluentDesignForm1() { WindowState = FormWindowState.Maximized});
			}
			else
			{
				Application.Exit();
			}
		}
	}


}