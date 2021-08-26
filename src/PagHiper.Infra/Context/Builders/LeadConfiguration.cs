using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PagHiper.Domain.Entities;

namespace PagHiper.Infra.Context.Builders
{
    public class LeadConfiguration : IEntityTypeConfiguration<Lead>

    {
        public void Configure(EntityTypeBuilder<Lead> builder)
        {
            builder.ToTable("Lead");
            builder.HasKey(l => l.Id);
            //builder.Property(x => x.Id)
	           // .HasColumnType("varchar")
	           // .HasMaxLength(36);

        }
    }
}