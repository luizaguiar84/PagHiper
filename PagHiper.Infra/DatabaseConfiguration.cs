using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace PagHiper.Infra
{
	public class DatabaseConfiguration
	{
		public string ConnectionStringName { get; }
		public string ConnectionString { get; }
		public DatabaseType DatabaseType { get; }

		public DatabaseConfiguration(IConfiguration configuration)
		{
			ConnectionStringName = configuration["DefaultConnectionString"];

			if (DatabaseType.Sqlite.ToString().Equals(ConnectionStringName, StringComparison.CurrentCultureIgnoreCase))
			{
				DatabaseType = DatabaseType.Sqlite;
			}
			else if (DatabaseType.MySQL.ToString().Equals(ConnectionStringName, StringComparison.CurrentCultureIgnoreCase))
			{
				DatabaseType = DatabaseType.MySQL;
			}
			else
			{
				throw new NotSupportedException($"Invalid ConnectionString name '{ConnectionStringName}'.");
			}

			ConnectionString = configuration[$"ConnectionStrings:{ConnectionStringName}"];
		}

	}
	public enum DatabaseType
	{
		Sqlite,
		MySQL
	}
}
