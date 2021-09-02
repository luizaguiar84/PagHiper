using System.Collections.Generic;
using System.Threading.Tasks;
using PagHiper.Domain.Entities;

namespace PagHiper.Infra.Repositories.Interfaces
{
	public interface ILeadRepository
	{
		Task<Lead> GetById(int id);
		Task<IEnumerable<Lead>> GetAll();
		Task<int> CreateNew(Lead lead);
		Task Delete(int id);
	}
}