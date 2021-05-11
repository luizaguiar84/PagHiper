using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using PagHiper.Models;

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
			var boleto = new Models.Boleto
			{
				apiKey = "",
				days_due_date = "",
				discount_cents = "",
				fixed_description = false,
				notification_url = "",
				order_id = "",
				payer_city = "",
				payer_cpf_cnpj = "",
				payer_complement = "",
				payer_district = "",
				payer_email = "",
				payer_name = "",
				payer_number = "",
				payer_phone = "",
				payer_state = "",
				payer_street = "",
				payer_zip_code = "",
				shipping_methods = "",
				shipping_price_cents = "",
				type_bank_slip = "",
				items = new List<Item>
				{
					new Item
					{
						description = "",
						item_id = "",
						price_cents = "",
						quantity = ""
					}
				}
			};
			var pdfAddress = _boleto.GetPdfBoleto(boleto);

			File.WriteAllText(@"C:\TEMP\Boleto.txt", $"Boleto número: {boleto.order_id} - {pdfAddress}");
		}
	}
}
