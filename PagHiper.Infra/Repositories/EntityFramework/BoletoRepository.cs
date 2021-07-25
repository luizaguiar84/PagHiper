using System;
using System.Collections.Generic;
using System.Linq;
using PagHiper.Domain.Entities;

namespace PagHiper.Infra.Repositories.EntityFramework
{
	public class BoletoRepository
	{
		private readonly PagHiperContext _context;

		public BoletoRepository()
		{
			this._context = new PagHiperContext();
		}

		public void Delete(string orderId)
		{
			try
			{
				var boleto = GetBoletoById(orderId);
				_context.Boletos.Remove(boleto);
				_context.SaveChanges();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public void AddBoleto(Boleto boleto)
		{
			try
			{
				_context.Add(boleto);
				_context.SaveChanges();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public Boleto GetBoletoById(string orderId)
		{
			try
			{
				return _context.Boletos.Single(b => b.order_id == orderId);
			}

			catch (Exception)
			{
				throw;
			}
		}

		public Boleto GetBoleto()
		{
			var boleto = new Boleto
			{
				apiKey = "ApiKeyTeste",
				days_due_date = "10",
				discount_cents = "0",
				fixed_description = false,
				notification_url = "fsdfdss",
				order_id = Guid.NewGuid().ToString(),
				payer_city = "São Paulo",
				payer_cpf_cnpj = "11122233344",
				payer_complement = "Casa",
				payer_district = "Guarulhos",
				payer_email = "lma@updi.net",
				payer_name = "Luiz",
				payer_number = "336",
				payer_phone = "11999271107",
				payer_state = "SP",
				payer_street = "Rua Nossa Senhora de Lourdes",
				payer_zip_code = "07074030",
				shipping_methods = "",
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
