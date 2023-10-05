using DaprDemo.Inventory.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DaprDemo.Inventory.Infrastructure.Context.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands");
            builder.HasKey(brand => brand.Id);
            builder.Property(brand => brand.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.HasData(
                new Brand(1, "Lamborghini"),
                new Brand(2, "Ferrari"),
                new Brand(3, "Vinfast"));

        }
    }
}
