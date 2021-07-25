using System.Data;

namespace PagHiper.Infra.Repositories.Dapper.Interfaces
{
	public interface IConnectionFactory
	{
		public IDbConnection Connection();
	}
}
