using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using PagHiper.Models;
using PagHiper.Repository.Interfaces;

namespace PagHiper.Repository
{
	class BoletoRepository : IBoletoRepository
	{
		private readonly IConnectionFactory connection;

		public BoletoRepository(IConnectionFactory connection)
		{
			this.connection = connection;
		}
		public async Task<IEnumerable<Boleto>> GetBoletos()
		{
			var query = "SELECT * from Boletos;";

			IList<Boleto> boletos = new List<Boleto>();

			using var connectionDb = connection.Connection();
			connectionDb.Open();
			var result = await connectionDb.QueryAsync<Boleto>(query);

			if (result.Any())
			{
				foreach (var item in result.ToList())
				{
					boletos.Add(item);
				}
			}
			return boletos;
		}

		public Task<Boleto> InsertBoleto(Boleto boleto)
		{
			throw new NotImplementedException();
		}

		public Task<Boleto> UpdateBoleto(Boleto boleto)
		{
			throw new NotImplementedException();
		}

		public Task<Boleto> DeleteBoleto(Guid boletoId)
		{
			throw new NotImplementedException();
		}

		public async Task<Boleto> GetBoleto(string orderId)
		{
			var query = "SELECT * from Boletos WHERE order_id = @orderId";
			IList<Boleto> listaBoletos = new List<Boleto>();

			using var connection = this.connection.Connection();
			connection.Open();

			var result = await connection.QueryFirstOrDefaultAsync<Boleto>(query, new {orderId = orderId});

			return result;

		}
	}
}
