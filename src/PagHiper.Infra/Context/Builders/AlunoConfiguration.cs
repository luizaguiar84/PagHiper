using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PagHiper.Domain.Entities.Aluno;
using PagHiper.Domain.Entities.Common;

namespace PagHiper.Infra.Context.Builders
{
	public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
	{
		public void Configure(EntityTypeBuilder<Aluno> builder)
		{
			builder.ToTable("Aluno");

			builder.HasKey(a => a.Id);
			builder.Property(a => a.DataCadastro).IsRequired();

			builder
				.HasMany(a => a.Contatos)
				.WithOne(a => a.Aluno)
				.HasForeignKey(a => a.AlunoId);
			
			builder
				.HasMany(a => a.Turmas)
				.WithOne(a => a.Aluno)
				.HasForeignKey(a => a.AlunoId);

			builder
				.HasOne(a => a.Endereco)
				.WithOne(a => a.Aluno)
				.HasForeignKey<Endereco>(e => e.AlunoId);

			builder
				.HasOne(a => a.Parcelas)
				.WithOne(a => a.Aluno)
				.HasForeignKey<AlunoParcelas>(a => a.AlunoId);

			builder
				.HasOne(a => a.Matricula)
				.WithOne(a => a.Aluno)
				.HasForeignKey<AlunoMatricula>(a => a.AlunoId);
		}
	}
}