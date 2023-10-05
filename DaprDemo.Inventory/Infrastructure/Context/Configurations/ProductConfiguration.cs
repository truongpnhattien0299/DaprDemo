using DaprDemo.Inventory.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DaprDemo.Inventory.Infrastructure.Context.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(product => product.Id);
            builder.Property(product => product.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(product => product.Price)
                .IsRequired();
            builder.Property(product => product.Quantity)
                .IsRequired();

            builder.HasOne(product => product.Brand)
                .WithMany()
                .HasForeignKey(product => product.BrandId);

            builder.HasOne(product => product.ProductType)
                .WithMany()
                .HasForeignKey(product => product.ProductTypeId);

            builder.HasData(
                new Product(1, "Lamboghini Aventador", 100, 199, 1, 1),
                new Product(2, "Super Ferrari", 100, 299, 2, 1),
                new Product(3, "VF 8", 100, 199, 3, 1));

        }
    }
}
