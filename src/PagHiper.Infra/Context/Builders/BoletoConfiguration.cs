using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PagHiper.Domain.Entities;

namespace PagHiper.Infra.Context.Builders
{
	class BoletoConfiguration : IEntityTypeConfiguration<Boleto>
	{
		public void Configure(EntityTypeBuilder<Boleto> builder)
		{
			builder.ToTable("Boleto");

			builder.HasKey(a => a.Id);

			builder
				.HasMany(a => a.Items)
				.WithOne(a => a.Boleto)
				.HasForeignKey(a => a.BoletoId);
		}
	}
}
