using System;
using System.Collections.Generic;
using System.Text;

namespace PagHiper.Domain.Entities
{
	public class AlunoTurma : BaseEntity
	{
		public DateTime DataIngresso { get; set; }
		public Turma Turma { get; set; }
		public bool Status { get; set; }
	}

	public class Turma : BaseEntity
	{
		public string Nome { get; set; }
	}
}
