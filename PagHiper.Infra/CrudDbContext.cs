using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PagHiper.Domain.Entities;

namespace PagHiper.Infra
{
	public class CrudDbContext : DbContext
	{
		public DbSet<Boleto> Boletos { get; set; }
		public DbSet<Aluno> Alunos{ get; set; }
		//public DbSet<AlunoContato> AlunoContatos{ get; set; }
		//public DbSet<AlunoMatricula> AlunoMatriculas{ get; set; }
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
			base.OnModelCreating(modelBuilder);
		}
	}
}
