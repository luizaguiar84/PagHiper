using System.Threading.Tasks;
using PagHiper.Domain.Entities;
using PagHiper.Infra.Repositories.Dapper.Interfaces;

namespace PagHiper.Infra.Repositories.Dapper
{
	class PagHiperRepository
	{
		private readonly IConnectionFactory connection;

		public PagHiperRepository(IConnectionFactory connection)
		{
			this.connection = connection;
		}

		public async Task<Boleto> InsertBoleto(Boleto boleto)
		{
			return boleto;
		}
	}
}
