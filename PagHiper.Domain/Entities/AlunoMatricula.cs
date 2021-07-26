using System;
using System.Collections.Generic;
using System.Text;

namespace PagHiper.Domain.Entities
{
	public class AlunoMatricula : BaseEntity
	{
		public Guid AlunoId { get; set; }
		public string NumeroRegistro { get; set; }
		public decimal Valor { get; set; }
		public string PagamentoTipoId { get; set; }
		public string PagamentoId { get; set; }
		public string CursoId { get; set; }
		public DateTime? DataMatricula { get; set; }
		public string CampanhaId { get; set; }
	}
}
