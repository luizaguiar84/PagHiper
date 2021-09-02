using System.Collections.Generic;
using System.Linq;
using PagHiper.Domain.Entities;
using PagHiper.Infra.Context;
using PagHiper.Infra.Repositories.Interfaces;

namespace PagHiper.Infra.Repositories
{
	public class BoletoRepository : IBoletoRepository
	{
		private readonly CrudDbContext _context;

		public BoletoRepository(CrudDbContext context)
		{
			this._context = context;
		}

		public void Delete(int id)
		{
			var boleto = GetById(id);
			_context.Boleto.Remove(boleto);
			_context.SaveChanges();
		}

		public void Add(Boleto boleto)
		{
			_context.Add(boleto);
			_context.SaveChanges();
		}

		public Boleto GetById(int id)
		{
			return _context.Boleto.Single(b => b.Id == id);
		}

		public List<Boleto> GetAll()
		{

			var listaBoletos = _context.Boleto.ToList();

			return listaBoletos;
			//var Boleto = new Boleto
			//{
			//	ApiKey = "ApiKeyTeste",
			//	DaysDueDate = "10",
			//	DiscountCents = "0",
			//	FixedDescription = false,
			//	NotificationUrl = "fsdfdss",
			//	OrderId = Guid.NewGuid().ToString(),
			//	PayerCity = "São Paulo",
			//	PayerCpfCnpj = "11122233344",
			//	PayerComplement = "Casa",
			//	PayerDistrict = "Guarulhos",
			//	PayerEmail = "lma@updi.net",
			//	PayerName = "Luiz",
			//	PayerNumber = "336",
			//	PayerPhone = "11999271107",
			//	PayerState = "SP",
			//	PayerStreet = "Rua Nossa Senhora de Lourdes",
			//	PayerZipCode = "07074030",
			//	ShippingMethods = "",
			//	ShippingPriceCents = "0",
			//	TypeBankSlip = "0",
			//	Items = new List<Item>
			//	{
			//		new Item
			//		{
			//			Description = "Descricao",
			//			Id = Guid.NewGuid(),
			//			PriceCents = "1000",
			//			Quantity = "1"
			//		}
			//	}
			//};


		}
	}
}
