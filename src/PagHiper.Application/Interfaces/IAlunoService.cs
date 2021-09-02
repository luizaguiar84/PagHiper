using System;
using System.Collections.Generic;
using PagHiper.Domain.Entities.Aluno;

namespace PagHiper.Application.Interfaces
{
    public interface IAlunoService
    {
        public List<Aluno> GetAll();
        Aluno GetById(int id);
        void Add(Aluno aluno);
        void Update(Aluno aluno);
        void Delete(int id);
    }
    
    
}