using System;
using System.Collections.Generic;
using PagHiper.Domain.Entities.Common;

namespace PagHiper.Infra.Repositories.Interfaces
{
	public interface IEnderecoRepository
	{
		void Delete(int enderecoId);
		Endereco Add(Endereco endereco);
		Endereco GetById(int enderecoId);
		List<Endereco> GetAll();
		void Update(Endereco endereco);
	}
}