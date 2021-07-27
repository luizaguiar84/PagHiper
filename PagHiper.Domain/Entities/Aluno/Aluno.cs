using System;
using System.Collections.Generic;
using System.ComponentModel;
using PagHiper.Domain.Entities.Common;

namespace PagHiper.Domain.Entities.Aluno
{
	public class Aluno : BaseEntity
	{
		public Aluno()
		{
			this.Endereco = new Endereco();
			this.Contatos = new List<AlunoContato>();
			this.Parcelas = new AlunoParcelas();
			this.Matricula = new AlunoMatricula();
			this.Turmas = new List<AlunoTurma>();
		}
		public string Cpf { get; set; }
		public string Rg { get; set; }
		public string Nome { get; set; }
		public Endereco Endereco { get; set; }
		
		[DisplayName("Data de Nascimento")]
		public DateTimeOffset? DataNascimento { get; set; }
		[DisplayName("Data de Cadastro")]
		public DateTimeOffset? DataCadastro { get; set; }
		[DisplayName("Data de Atualização")]
		public DateTimeOffset? DataAtualizacao { get; set; }
		public string ResponsavelNome { get; set; }
		public string ResponsavelCpf { get; set; }
		public string ResponsavelParentesco { get; set; }
		public string ResponsavelTelefone { get; set; }
		public char StatusCadastro { get; set; }
		public char StatusFinanceiro { get; set; }
		[DisplayName("Observação")]
		public string Observacao { get; set; }
		public bool IsActive { get; set; }

		public ICollection<AlunoContato> Contatos { get; set; }
		public AlunoParcelas Parcelas { get; set; }
		public AlunoMatricula Matricula { get; set; }
		public ICollection<AlunoTurma> Turmas { get; set; }
		
	}
}
