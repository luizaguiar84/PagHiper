﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PagHiper.Domain.Entities.Aluno;
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

		public void Delete(Guid alunoId)
		{
			try
			{
				var aluno = GetById(alunoId);
				_context.Alunos.Remove(aluno);
				_context.SaveChanges();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public Aluno Add(Aluno aluno)
		{
			try
			{
				var ret = _context.Add(aluno);
				_context.SaveChanges();
				return ret.Entity;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public Aluno GetById(Guid alunoId)
		{
			try
			{
				var aluno = 
					_context.Alunos
						.Include(a => a.Endereco)
						.Include(a => a.Contatos)
						.SingleOrDefault(a => a.Id == alunoId);
				
				return aluno;
			}

			catch (Exception)
			{
				throw;
			}
		}

		public List<Aluno> GetAll()
		{
			var listaAlunos = _context.Alunos.ToList();
			return listaAlunos;
		}

		public Aluno Update(Aluno aluno)
		{
			var ret = _context.Alunos.Update(aluno);
			_context.SaveChanges();

			return ret.Entity;
		}
	}
}
