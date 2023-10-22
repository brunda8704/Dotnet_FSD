using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductAPI.Models;

namespace ProductAPI.DBContext.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn(100,1);

            builder.Property(x=>x.ProductName)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(x=>x.ProductDescription)
                   .IsRequired()
                   .HasMaxLength(20);
        }
    }
}
