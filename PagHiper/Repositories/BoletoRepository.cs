using System;
using System.Collections.Generic;
using System.Linq;
using PagHiper.Models;

namespace PagHiper.Repositories
{
	public class BoletoRepository
	{
		private readonly PagHiperContext _context;

		public BoletoRepository()
		{
			this._context = new PagHiperContext();
		}

		public void AddBoleto(Boleto boleto)
		{
			_context.Add(boleto);
			_context.SaveChanges();
		}

		public Boleto GetBoletoById(string order_id)
		{
			return _context.Boletos.Single(b => b.order_id == order_id);
		}

		public Boleto GetBoleto()
		{
			var boleto = new Boleto
			{
				apiKey = "fsdfdsafas",
				days_due_date = "fsdfsfdsa",
				discount_cents = "fdsfsdafsa",
				fixed_description = false,
				notification_url = "fsdfdss",
				order_id = Guid.NewGuid().ToString(),
				payer_city = "fdsfsd",
				payer_cpf_cnpj = "fsdfas",
				payer_complement = "fdsafsa",
				payer_district = "Guarulhos",
				payer_email = "lma@updi.net",
				payer_name = "Luiz",
				payer_number = "336",
				payer_phone = "11999271107",
				payer_state = "SP",
				payer_street = "Rua Nossa Senhora de Lourdes",
				payer_zip_code = "07074030",
				shipping_methods = "xx",
				shipping_price_cents = "0",
				type_bank_slip = "0",
				items = new List<Item>
				{
					new Item
					{
						description = "Descricao",
						item_id = Guid.NewGuid().ToString(),
						price_cents = "1000",
						quantity = "1"
					}
				}
			};

			AddBoleto(boleto);

			return GetBoletoById(boleto.order_id);
		}
	}
}
