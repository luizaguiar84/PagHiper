using System;
using System.Collections.Generic;
using PagHiper.Application.Interfaces;
using PagHiper.Domain.Entities.Common;
using PagHiper.Infra.Repositories.Interfaces;

namespace PagHiper.Application.Services
{
	public class EnderecoService : IEnderecoService
	{
		private readonly IEnderecoRepository _enderecoRepository;

		public EnderecoService(IEnderecoRepository enderecoRepository)
		{
			this._enderecoRepository = enderecoRepository;
		}
		public IEnumerable<Endereco> GetAll()
		{
			return _enderecoRepository.GetAll();
		}

		public Endereco GetById(int id)
		{
			return _enderecoRepository.GetById(id);
		}

		public void Update(Endereco endereco)
		{
			_enderecoRepository.Update(endereco);
		}

		public void Delete(int id)
		{
			_enderecoRepository.Delete(id);
		}

		public void Add(Endereco endereco)
		{
			_enderecoRepository.Add(endereco);
		}
	}


}