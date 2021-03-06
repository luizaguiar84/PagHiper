using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PagHiper.Domain.Entities.Aluno;
using PagHiper.Infra.Context;
using PagHiper.Infra.Repositories.Interfaces;

namespace PagHiper.Infra.Repositories
{
	public class AlunoRepository : IAlunoRepository
	{
		private readonly CrudDbContext _context;

		public AlunoRepository(CrudDbContext context)
		{
			this._context = context;
		}

		public void Delete(int alunoId)
		{
			var aluno = GetById(alunoId);
			_context.Aluno.Remove(aluno);
			_context.SaveChanges();
		}

		public Aluno Add(Aluno aluno)
		{
			var ret = _context.Add(aluno);
			_context.SaveChanges();
			return ret.Entity;
		}

		public Aluno GetById(int alunoId)
		{
			var aluno = 
				_context.Aluno
					.AsNoTracking()
					.Include(a => a.Endereco)
					.Include(a => a.Contatos)
					.Include(a => a.Parcelas)
					.Include(a => a.Matricula)
					.Include(a => a.Turmas)
					.SingleOrDefault(a => a.Id == alunoId);
				
			return aluno;
		}

		public List<Aluno> GetAll()
		{
			var listaAlunos = _context.Aluno.ToList();
			return listaAlunos;
		}

		public void Update(Aluno aluno)
		{
			_context.Entry(aluno).State = EntityState.Modified;
			//var ret = _context.Aluno.Update(aluno);
			_context.SaveChanges();

			//return true;
		}
	}
}
