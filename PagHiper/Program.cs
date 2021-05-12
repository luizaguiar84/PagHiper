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
			using var dbContext = new PagHiperContext();
			//cria o banco
			dbContext.Database.EnsureCreated();

			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
