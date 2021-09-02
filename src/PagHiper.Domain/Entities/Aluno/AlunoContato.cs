namespace PagHiper.Domain.Entities.Aluno
{
	public class AlunoContato : BaseEntity
	{
		public string Tipo { get; set; }
		public string Contato { get; set; }
		public string Observacao { get; set; }
		public Aluno Aluno { get; set; }
		public int AlunoId { get; set; }

	}
}
