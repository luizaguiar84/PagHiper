using System;
using System.Collections.Generic;
using System.Linq;
using PagHiper.Domain.Entities;

namespace PagHiper.Infra.Repositories.EntityFramework
{
	public class BoletoRepository
	{
		private readonly CrudDbContext _context;

		public BoletoRepository(CrudDbContext context)
		{
			this._context = context;
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
				return _context.Boletos.Single(b => b.OrderId == orderId);
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
				ApiKey = "ApiKeyTeste",
				DaysDueDate = "10",
				DiscountCents = "0",
				FixedDescription = false,
				NotificationUrl = "fsdfdss",
				OrderId = Guid.NewGuid().ToString(),
				PayerCity = "São Paulo",
				PayerCpfCnpj = "11122233344",
				PayerComplement = "Casa",
				PayerDistrict = "Guarulhos",
				PayerEmail = "lma@updi.net",
				PayerName = "Luiz",
				PayerNumber = "336",
				PayerPhone = "11999271107",
				PayerState = "SP",
				PayerStreet = "Rua Nossa Senhora de Lourdes",
				PayerZipCode = "07074030",
				ShippingMethods = "",
				ShippingPriceCents = "0",
				TypeBankSlip = "0",
				Items = new List<Item>
				{
					new Item
					{
						Description = "Descricao",
						Id = Guid.NewGuid(),
						PriceCents = "1000",
						Quantity = "1"
					}
				}
			};

			AddBoleto(boleto);

			return GetBoletoById(boleto.OrderId);
		}
	}
}
