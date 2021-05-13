using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagHiper.Models;
using PagHiper.Repository.Interfaces;

namespace PagHiper.Repository
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
