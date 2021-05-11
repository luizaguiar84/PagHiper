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

		public Form1()
		{
			this._boleto = new BLL.Boleto();
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var boleto = BoletoRepository.GetBoleto();
			
			var pdfAddress = _boleto.GetPdfBoleto(boleto);
			var linhaDigitavel = _boleto.GetDigitableLineBoleto(boleto);

			File.WriteAllText(@"C:\TEMP\Boleto.txt", $"Boleto número: {boleto.order_id} - PDF: {pdfAddress} | Linha Digitável: {linhaDigitavel}");
		}
	}
}
