using System;
using System.IO;
using System.Windows.Forms;
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

				this.txt_OrderId.Text = boleto.order_id;

				var pdfAddress = _boleto.GetPdfBoleto(boleto);
				var linhaDigitavel = _boleto.GetDigitableLineBoleto(boleto);

				File.WriteAllText(@"C:\TEMP\Boleto.txt", $"Boleto número: {boleto.order_id} - PDF: {pdfAddress} | Linha Digitável: {linhaDigitavel}");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			_repository.Delete(this.txt_OrderId.Text);
		}
	}
}
