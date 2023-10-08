using DaprDemo.Ordering.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DaprDemo.Ordering.Infrastructure.Context.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(order => order.Id);
            builder.Property(order => order.UserId)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(order => order.CreatedAt)
                .HasDefaultValue(DateTime.Now);

        }
    }
}
