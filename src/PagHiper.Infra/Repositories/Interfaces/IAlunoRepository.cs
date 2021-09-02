using System.Collections.Generic;
using PagHiper.Domain.Entities.Aluno;

namespace PagHiper.Infra.Repositories.Interfaces
{
	public interface IAlunoRepository
	{
		void Delete(int alunoId);
		Aluno Add(Aluno aluno);
		Aluno GetById(int alunoId);
		List<Aluno> GetAll();
		void Update(Aluno aluno);
	}
}