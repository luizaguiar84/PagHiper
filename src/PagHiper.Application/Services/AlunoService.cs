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
	        var alunos = _alunoRepository.GetAll();
	        return alunos;
        }

        public Aluno GetById(Guid id)
        {
	        return _alunoRepository.GetById(id);
        }

        public void Add(Aluno aluno)
        {
	        _alunoRepository.Add(aluno);
        }

        public void Update(Aluno aluno)
        {
            _alunoRepository.Update(aluno);
        }

        public void Delete(Guid id)
        {
            _alunoRepository.Delete(id);
        }
    }
}