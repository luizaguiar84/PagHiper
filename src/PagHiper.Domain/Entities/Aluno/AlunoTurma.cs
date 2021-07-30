using System;

namespace PagHiper.Domain.Entities.Aluno
{
	public class AlunoTurma : BaseEntity
	{
		public DateTimeOffset DataIngresso { get; set; }
		public Turma Turma { get; set; }
		public bool Status { get; set; }
		public Aluno Aluno { get; set; }
		public Guid AlunoId { get; set; }

	}
}
