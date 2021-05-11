using System;
using System.Collections.Generic;
using PagHiper.Models;

namespace PagHiper.Repositories
{
	public class BoletoRepository
	{
		public static Boleto GetBoleto()
		{
			return new Boleto
			{
				apiKey = "",
				days_due_date = "",
				discount_cents = "",
				fixed_description = false,
				notification_url = "",
				order_id = Guid.NewGuid().ToString(),
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
		}

		public static List<Boleto> GetListaBoletos()
		{
			return new List<Boleto>
			{
				GetBoleto(),
				GetBoleto(),
				GetBoleto()
			};
		}
	}
}
