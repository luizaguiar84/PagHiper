using System;

namespace PagHiper.Domain.Entities
{
	public class AlunoContato : BaseEntity
	{
		public Guid AlunoId { get; set; }
		public string Tipo { get; set; }
		public string Contato { get; set; }
		public string Observacao { get; set; }

	}
}
