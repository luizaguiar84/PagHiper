using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PagHiper.Domain.Entities;

namespace PagHiper.Infra
{
	public class CrudDbContext : DbContext
	{
		public DbSet<Boleto> Boletos { get; set; }
		
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
