//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Dapper;
//using PagHiper.Domain.Entities;
//using PagHiper.Infra.Repositories.Dapper.Interfaces;

//namespace PagHiper.Infra.Repositories.Dapper
//{
//	class BoletoRepository : IBoletoRepository
//	{
//		private readonly IConnectionFactory connection;

//		public BoletoRepository(IConnectionFactory connection)
//		{
//			this.connection = connection;
//		}
//		public async Task<IEnumerable<Boleto>> GetBoletos()
//		{
//			var query = "SELECT * from Boletos;";

//			IList<Boleto> boletos = new List<Boleto>();

//			using var connectionDb = connection.Connection();
//			connectionDb.Open();
//			var result = await connectionDb.QueryAsync<Boleto>(query);

//			if (result.Any())
//			{
//				foreach (var item in result.ToList())
//				{
//					boletos.Add(item);
//				}
//			}
//			return boletos;
//		}

//		public Task<Boleto> InsertBoleto(Boleto boleto)
//		{
//			throw new NotImplementedException();
//		}

//		public Task<Boleto> UpdateBoleto(Boleto boleto)
//		{
//			throw new NotImplementedException();
//		}

//		public async Task<int> DeleteBoleto(string boletoId)
//		{
//			var query = "DELETE * FROM Boletos WHERE OrderId = @orderId";
//			var connectionDb = connection.Connection();
//			connectionDb.Open();
//			var result = await connectionDb.ExecuteAsync(query);
//			return result;
//		}

//		public async Task<Boleto> GetBoleto(string boletoId)
//		{
//			var boleto = new Boleto
//			{
//				ApiKey = "ApiKeyTeste",
//				DaysDueDate = "10",
//				DiscountCents = "0",
//				FixedDescription = false,
//				NotificationUrl = "fsdfdss",
//				OrderId = Guid.NewGuid().ToString(),
//				PayerCity = "São Paulo",
//				PayerCpfCnpj = "11122233344",
//				PayerComplement = "Casa",
//				PayerDistrict = "Guarulhos",
//				payer_email = "lma@updi.net",
//				PayerName = "Luiz",
//				PayerNumber = "336",
//				PayerPhone = "11999271107",
//				PayerState = "SP",
//				PayerStreet = "Rua Nossa Senhora de Lourdes",
//				PayerZipCode = "07074030",
//				ShippingMethods = "",
//				ShippingPriceCents = "0",
//				TypeBankSlip = "0",
//				Items = new List<VisualStyleElement.Header.Item>
//				{
//					new VisualStyleElement.Header.Item
//					{
//						Description = "Descricao",
//						ItemId = Guid.NewGuid().ToString(),
//						PriceCents = "1000",
//						Quantity = "1"
//					}
//				}
//			};

			

//			var query = "SELECT * from Boletos WHERE OrderId = @orderId";
//			IList<Boleto> listaBoletos = new List<Boleto>();

//			using var connectionDb = this.connection.Connection();
//			connectionDb.Open();
//			var insert = 
//			var result = await connectionDb.QueryFirstOrDefaultAsync<Boleto>(query, new { orderId = boletoId });

//			return result;
//		}

		
//	}
//}
