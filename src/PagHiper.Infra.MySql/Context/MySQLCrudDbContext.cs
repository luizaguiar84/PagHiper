using Microsoft.EntityFrameworkCore;

namespace PagHiper.Infra.MySql.Context
{
	public class MySqlCrudDbContext : CrudDbContext
	{
		public MySqlCrudDbContext(DbContextOptions options)
			: base(options) { }
	}
}
