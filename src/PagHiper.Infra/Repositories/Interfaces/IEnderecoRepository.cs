using System;
using System.Collections.Generic;
using PagHiper.Domain.Entities.Common;

namespace PagHiper.Infra.Repositories.Interfaces
{
	public interface IEnderecoRepository
	{
		void Delete(Guid enderecoId);
		Endereco Add(Endereco aluno);
		Endereco GetById(Guid enderecoId);
		List<Endereco> GetAll();
		void Update(Endereco endereco);
	}
}