using System.ComponentModel.DataAnnotations;

namespace PagHiper.Domain.Entities
{
	public abstract class BaseEntity
	{
		[Key]
		public int Id { get; set; }
	}
}
