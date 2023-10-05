using DaprDemo.Inventory.Domain;
using DaprDemo.Inventory.Infrastructure.Context.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DaprDemo.Inventory.Infrastructure.Context
{
    public class InventoryDbContext : DbContext
    {
        public DbSet<Brand> Brands => Set<Brand>();
        public DbSet<ProductType> ProductTypes => Set<ProductType>();
        public DbSet<Product> Products => Set<Product>();

        public InventoryDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BrandConfiguration());
            builder.ApplyConfiguration(new ProductTypeConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}
