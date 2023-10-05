using DaprDemo.Inventory.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DaprDemo.Inventory.Infrastructure.Context.Configurations
{
    public class ProductTypeConfiguration : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.ToTable("ProductTypes");
            builder.HasKey(productType => productType.Id);
            builder.Property(productType => productType.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.HasData(
                new ProductType(1, "Car"),
                new ProductType(2, "Motobike"),
                new ProductType(3, "Cycelbike"));

        }
    }
}
