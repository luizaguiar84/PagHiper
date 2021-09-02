﻿namespace PagHiper.Domain.Entities.Common
{
	public class Endereco : BaseEntity
	{
		public int AlunoId { get; set; }
		
		public Aluno.Aluno Aluno { get; set; }
		public string Cep { get; set; }
		public string Rua { get; set; }
		public string Numero { get; set; }
		public string Complemento { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string Uf { get; set; }
	}
}