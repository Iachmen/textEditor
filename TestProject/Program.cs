using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditorBL;

namespace TestProject
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			MainForm mainForm = new MainForm();
			MessageService mService = new MessageService();
			FileManager fManager = new FileManager();
			MainPresenter mPresenter = new MainPresenter(mainForm, fManager, mService);
			Application.Run(mainForm);
		}
	}
}
