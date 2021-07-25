using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PagHiper.Domain.Entities;

namespace PagHiper.Infra
{
	public class PagHiperContext : DbContext
	{
		public const string NomeBanco = "PagHiper.db";
		public DbSet<Boleto> Boletos { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite($"Filename={NomeBanco}", options =>
			{
				options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
			});
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//Map table names
			//modelBuilder.Entity<Boleto>().ToTable("Boletos", "Boletos");
			modelBuilder.Entity<Boleto>(entity =>
			{
				entity.HasKey(b => b.order_id);
				entity.HasMany(b => b.items);
			});
			base.OnModelCreating(modelBuilder);
		}
	}
}
