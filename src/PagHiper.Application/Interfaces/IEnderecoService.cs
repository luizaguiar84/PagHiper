using System;
using System.Collections.Generic;
using PagHiper.Domain.Entities.Common;

namespace PagHiper.Application.Interfaces
{
    public interface IEnderecoService
    {
        public IEnumerable<Endereco> GetAll();
        public Endereco GetById(Guid id);
        public void Update(Endereco endereco);
        void Delete(Guid id);
        void Add(Endereco endereco);
    }
}