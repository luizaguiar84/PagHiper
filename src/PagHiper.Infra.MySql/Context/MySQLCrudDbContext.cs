using Microsoft.EntityFrameworkCore;
using PagHiper.Infra.Context;

namespace PagHiper.Infra.MySql.Context
{
	public class MySqlCrudDbContext : CrudDbContext
	{
		public MySqlCrudDbContext(DbContextOptions options)
			: base(options) { }
	}
}
