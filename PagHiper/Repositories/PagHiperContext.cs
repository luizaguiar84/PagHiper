using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PagHiper.Models;

namespace PagHiper.Repositories
{
	public class PagHiperContext : DbContext
	{
		public DbSet<Boleto> Boletos { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Filename=PagHiper.db", options =>
			{
				options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
			});
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//Map table names
			modelBuilder.Entity<Boleto>().ToTable("Boletos", "Boletos");
			modelBuilder.Entity<Boleto>(entity =>
			{
				entity.HasKey(b => b.order_id);
				entity.HasIndex(b => b.payer_cpf_cnpj);
			});
			base.OnModelCreating(modelBuilder);
		}
	}
}
