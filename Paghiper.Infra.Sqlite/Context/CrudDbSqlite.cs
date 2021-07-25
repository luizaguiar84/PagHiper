using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PagHiper.Infra;

namespace Paghiper.Infra.Sqlite.Context
{
	public class CrudDbSqlite : CrudDbContext
	{
		public const string NomeBanco = "PagHiper.db";

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite($"Filename={NomeBanco}", options =>
			{
				options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
			});
			base.OnConfiguring(optionsBuilder);
		}
	}
}
