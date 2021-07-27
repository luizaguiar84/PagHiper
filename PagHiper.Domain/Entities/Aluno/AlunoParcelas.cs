using System;

namespace PagHiper.Domain.Entities.Aluno
{
	public class AlunoParcelas : BaseEntity
	{
		public Guid AlunoId { get; set; }
		public string TipoPagamentoId { get; set; }
		public DateTime DataVencimento { get; set; }
		public decimal Valor { get; set; }
		public string PagamentoEfetuadoId { get; set; }
		public string PagamentoEfetuado { get; set; }
		public DateTime? DataPagamentoEfetuado { get; set; }
		public decimal ValorEfetuado { get; set; }
		public int NumeroParcelas { get; set; }
		public int NumeroTotalParcelas { get; set; }
	}
}
