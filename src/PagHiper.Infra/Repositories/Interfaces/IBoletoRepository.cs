using System.Collections.Generic;
using PagHiper.Domain.Entities;

namespace PagHiper.Infra.Repositories.Interfaces
{
	public interface IBoletoRepository
	{
		void Delete(int id);
		void Add(Boleto boleto);
		Boleto GetById(int id);
		List<Boleto> GetAll();
	}
}