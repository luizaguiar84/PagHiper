using System;
using System.Collections.Generic;
using PagHiper.Domain.Entities;

namespace PagHiper.Infra.Repositories.Interfaces
{
	public interface IBoletoRepository
	{
		void Delete(Guid id);
		void Add(Boleto boleto);
		Boleto GetById(Guid id);
		List<Boleto> GetAll();
	}
}