using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagHiper.Repository.Interfaces;

namespace PagHiper.Repository
{
	class DefaultSqlConnection : IConnectionFactory
	{
		public IDbConnection Connection()
		{
			return new SqlConnection("Database=HeroDb;Data Source=(localdb)\\MSSQLLocalDB");
		}
	}
}
