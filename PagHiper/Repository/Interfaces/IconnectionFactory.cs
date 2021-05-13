using System.Data;

namespace PagHiper.Repository.Interfaces
{
	public interface IConnectionFactory
	{
		public IDbConnection Connection();
	}
}
