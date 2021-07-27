using System.Collections.Generic;
using PagHiper.Domain.Entities;

namespace PagHiper.Infra.Repositories.Interfaces
{
	public interface IBoletoRepository
	{
		void Delete(string orderId);
		void Add(Boleto boleto);
		Boleto GetById(string orderId);
		List<Boleto> GetAll();
	}
}