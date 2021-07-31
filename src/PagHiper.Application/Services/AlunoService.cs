using System;
using System.Collections.Generic;
using PagHiper.Application.Interfaces;
using PagHiper.Domain.Entities.Aluno;
using PagHiper.Infra.Repositories.Interfaces;

namespace PagHiper.Application.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            this._alunoRepository = alunoRepository;
        }


        public List<Aluno> GetAll()
        {
            throw new NotImplementedException();
        }

        public Aluno GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Add(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public void Update(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}