using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace PagHiper.Domain.Entities
{
	public class Aluno : BaseEntity
	{
		public string Cpf { get; set; }
		public string Rg { get; set; }
		public string Nome { get; set; }
		public Endereco Endereco { get; set; }
		public DateTime? DataNascimento { get; set; }
		public DateTime? DataCadastro { get; set; }
		public DateTime? DataAtualizacao { get; set; }
		public string ResponsavelNome { get; set; }
		public string ResponsavelCpf { get; set; }
		public string ResponsavelParentesco { get; set; }
		public string ResponsavelTelefone { get; set; }
		public char StatusCadastro { get; set; }
		public char StatusFinanceiro { get; set; }
		public string Observacao { get; set; }
		public bool IsActive { get; set; }

		public ICollection<AlunoContato> Contatos { get; set; }
		public AlunoParcelas Parcelas { get; set; }
		public AlunoMatricula Matricula { get; set; }
		public ICollection<AlunoTurma> Turmas { get; set; }
		
	}
}
