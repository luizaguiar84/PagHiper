using System.Collections.Generic;
using System.Threading.Tasks;
using PagHiper.Domain.Entities;

namespace PagHiper.Infra.Repositories.Dapper.Interfaces
{
	interface IBoletoRepository
	{
		Task<IEnumerable<Boleto>> GetBoletos();
		Task<Boleto> InsertBoleto(Boleto boleto);
		Task<Boleto> UpdateBoleto(Boleto boleto);
		Task<int> DeleteBoleto(string boletoId);
		Task<Boleto> GetBoleto(string boletoId);



	}
}
