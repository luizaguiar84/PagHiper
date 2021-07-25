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
//			var query = "DELETE * FROM Boletos WHERE order_id = @orderId";
//			var connectionDb = connection.Connection();
//			connectionDb.Open();
//			var result = await connectionDb.ExecuteAsync(query);
//			return result;
//		}

//		public async Task<Boleto> GetBoleto(string boletoId)
//		{
//			var boleto = new Boleto
//			{
//				apiKey = "ApiKeyTeste",
//				days_due_date = "10",
//				discount_cents = "0",
//				fixed_description = false,
//				notification_url = "fsdfdss",
//				order_id = Guid.NewGuid().ToString(),
//				payer_city = "São Paulo",
//				payer_cpf_cnpj = "11122233344",
//				payer_complement = "Casa",
//				payer_district = "Guarulhos",
//				payer_email = "lma@updi.net",
//				payer_name = "Luiz",
//				payer_number = "336",
//				payer_phone = "11999271107",
//				payer_state = "SP",
//				payer_street = "Rua Nossa Senhora de Lourdes",
//				payer_zip_code = "07074030",
//				shipping_methods = "",
//				shipping_price_cents = "0",
//				type_bank_slip = "0",
//				items = new List<VisualStyleElement.Header.Item>
//				{
//					new VisualStyleElement.Header.Item
//					{
//						description = "Descricao",
//						item_id = Guid.NewGuid().ToString(),
//						price_cents = "1000",
//						quantity = "1"
//					}
//				}
//			};

			

//			var query = "SELECT * from Boletos WHERE order_id = @orderId";
//			IList<Boleto> listaBoletos = new List<Boleto>();

//			using var connectionDb = this.connection.Connection();
//			connectionDb.Open();
//			var insert = 
//			var result = await connectionDb.QueryFirstOrDefaultAsync<Boleto>(query, new { orderId = boletoId });

//			return result;
//		}

		
//	}
//}
