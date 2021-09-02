using System.Collections.Generic;
using PagHiper.Domain.Entities.Common;

namespace PagHiper.Application.Interfaces
{
    public interface IEnderecoService
    {
        public IEnumerable<Endereco> GetAll();
        public Endereco GetById(int id);
        public void Update(Endereco endereco);
        void Delete(int id);
        void Add(Endereco endereco);
    }
}