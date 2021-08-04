//using System;
//using System.Collections.Generic;
//using System.Linq;
//using Microsoft.EntityFrameworkCore;
//using PagHiper.Domain.Entities.Common;
//using PagHiper.Infra.Context;
//using PagHiper.Infra.Repositories.Interfaces;

//namespace PagHiper.Infra
//{
//	public class EnderecoRepository : IEnderecoRepository
//	{
//		private readonly CrudDbContext _context;

//		public EnderecoRepository(CrudDbContext context)
//		{
//			this._context = context;
//		}

//		public void Delete(Guid enderecoId)
//		{
//			try
//			{
//				var endereco = GetById(enderecoId);
//				_context.AlunoEndereco.Remove(endereco);
//				_context.SaveChanges();
//			}
//			catch (Exception)
//			{
//				throw;
//			}
//		}

//		public Endereco Add(Endereco endereco)
//		{
//			try
//			{
//				var ret = _context.Add(endereco);
//				_context.SaveChanges();
//				return ret.Entity;
//			}
//			catch (Exception)
//			{
//				throw;
//			}
//		}

//		public Endereco GetById(Guid enderecoId)
//		{
//			try
//			{
//				var aluno =
//					_context.AlunoEndereco
//						.SingleOrDefault(a => a.Id == enderecoId);

//				return aluno;
//			}

//			catch (Exception)
//			{
//				throw;
//			}
//		}

//		public List<Endereco> GetAll()
//		{
//			var listaEnderecos = _context.AlunoEndereco.ToList();
//			return listaEnderecos;
//		}

//		public void Update(Endereco endereco)
//		{
//			_context.Entry(endereco).State = EntityState.Modified;
//			_context.SaveChanges();

//			//return true;
//		}
//	}
//}
