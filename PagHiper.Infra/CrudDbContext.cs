using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PagHiper.Domain.Entities;
using PagHiper.Domain.Entities.Aluno;
using PagHiper.Domain.Entities.Common;

namespace PagHiper.Infra
{
	public class CrudDbContext : DbContext
	{
		public DbSet<Boleto> Boleto { get; set; }
		public DbSet<Aluno> Aluno { get; set; }
		public CrudDbContext()
		{ }

		public CrudDbContext(DbContextOptions options) : base(options)
		{ }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Boleto>(entity =>
			{
				entity.HasKey(b => b.OrderId);
				entity.HasMany(b => b.Items);
			});

			modelBuilder.Entity<Aluno>(entity =>
			{
				entity.HasKey(a => a.Id);

				entity.HasOne<AlunoMatricula>(a => a.Matricula)
					.WithOne(a=>a.Aluno).HasForeignKey<AlunoMatricula>(a => a.AlunoId).OnDelete(DeleteBehavior.Cascade);

				entity.HasOne<Endereco>(a => a.Endereco)
					.WithOne(a=>a.Aluno).HasForeignKey<Endereco>(a => a.AlunoId).OnDelete(DeleteBehavior.Cascade);

				entity.HasOne<AlunoParcelas>(a => a.Parcelas)
					.WithOne(a=>a.Aluno).HasForeignKey<AlunoParcelas>(a => a.AlunoId).OnDelete(DeleteBehavior.Cascade);

				entity.HasMany<AlunoTurma>(a => a.Turmas)
					.WithOne(a => a.Aluno).OnDelete(DeleteBehavior.Cascade);

				entity.HasMany<AlunoContato>(a => a.Contatos)
					.WithOne(a => a.Aluno).OnDelete(DeleteBehavior.Cascade);

			});
			base.OnModelCreating(modelBuilder);
		}
	}
}
