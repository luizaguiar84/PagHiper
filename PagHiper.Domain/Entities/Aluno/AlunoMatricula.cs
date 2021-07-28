using System;

namespace PagHiper.Domain.Entities.Aluno
{
	public class AlunoMatricula : BaseEntity
	{
		public Guid AlunoId { get; set; }
		public string NumeroRegistro { get; set; }
		public decimal Valor { get; set; }
		public string PagamentoTipoId { get; set; }
		public string PagamentoId { get; set; }
		public string CursoId { get; set; }
		public DateTimeOffset? DataMatricula { get; set; }
		public string CampanhaId { get; set; }
		public Aluno Aluno { get; set; }

	}
}
