using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PagHiper.Infra;

namespace Paghiper.Infra.Sqlite.Context
{
	public class SqliteCrudDbContext : CrudDbContext
	{
		public SqliteCrudDbContext(DbContextOptions options) 
			: base(options) { }
	}
}
