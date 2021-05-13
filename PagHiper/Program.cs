using System;
using System.Windows.Forms;
using PagHiper.Repositories;

namespace PagHiper
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			//cria o banco
			using var dbContext = new PagHiperContext();
			dbContext.Database.EnsureCreated();

			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
