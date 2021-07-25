using System.Data;
using System.Data.SqlClient;

namespace PagHiper.Infra.Repositories.Dapper.Interfaces
{
	class DefaultSqlConnection : IConnectionFactory
	{
		public IDbConnection Connection()
		{
			return new SqlConnection("Database=HeroDb;Data Source=(localdb)\\MSSQLLocalDB");
		}
	}
}
