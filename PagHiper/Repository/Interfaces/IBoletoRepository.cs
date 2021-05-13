using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagHiper.Models;

namespace PagHiper.Repository.Interfaces
{
	interface IBoletoRepository
	{
		Task<IEnumerable<Boleto>> GetBoletos();
		Task<Boleto> InsertBoleto(Boleto boleto);
		Task<Boleto> UpdateBoleto(Boleto boleto);
		Task<Boleto> DeleteBoleto(Guid boletoId);
		Task<Boleto> GetBoleto(Guid boletoId);



	}
}
