using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PagHiper.Domain.Entities.Aluno;

namespace PagHiper.Infra.Repositories.Interfaces
{
	public interface IAlunoRepository
	{
		void Delete(Guid alunoId);
		Aluno Add(Aluno aluno);
		Aluno GetById(Guid alunoId);
		List<Aluno> GetAll();
		Aluno Update(Aluno aluno);
	}
}