using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using PagHiper.Models;
using PagHiper.Repositories;

namespace PagHiper
{
	public partial class Form1 : Form
	{
		private readonly BLL.Boleto _boleto;
		private readonly BoletoRepository _repository;

		public Form1()
		{
			this._repository = new BoletoRepository();
			this._boleto = new BLL.Boleto();
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				var boleto = _repository.GetBoleto();

				var pdfAddress = _boleto.GetPdfBoleto(boleto);
				var linhaDigitavel = _boleto.GetDigitableLineBoleto(boleto);

				File.WriteAllText(@"C:\TEMP\Boleto.txt", $"Boleto número: {boleto.order_id} - PDF: {pdfAddress} | Linha Digitável: {linhaDigitavel}");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
