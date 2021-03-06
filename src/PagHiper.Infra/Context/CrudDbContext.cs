using Microsoft.EntityFrameworkCore;
using PagHiper.Domain.Entities;
using PagHiper.Domain.Entities.Aluno;
using PagHiper.Infra.Context.Builders;

namespace PagHiper.Infra.Context
{
	public class CrudDbContext : DbContext
	{
		public DbSet<Boleto> Boleto { get; set; }
		public DbSet<Aluno> Aluno { get; set; }
		
		public DbSet<Lead> Leads { get; set; }
		public CrudDbContext()
		{ }

		public CrudDbContext(DbContextOptions options) : base(options)
		{ }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			modelBuilder.ApplyConfiguration(new AlunoConfiguration());
			modelBuilder.ApplyConfiguration(new BoletoConfiguration());
			modelBuilder.ApplyConfiguration(new LeadConfiguration());

			base.OnModelCreating(modelBuilder);
		}
	}
}
