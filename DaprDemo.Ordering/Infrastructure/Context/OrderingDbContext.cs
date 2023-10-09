using DaprDemo.Ordering.Domain;
using Microsoft.EntityFrameworkCore;

namespace DaprDemo.Ordering.Infrastructure.Context
{
    public class OrderingDbContext : DbContext
    {
        public OrderingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Order> Orders => Set<Order>();
        public DbSet<OrderItem> OrderItems => Set<OrderItem>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}