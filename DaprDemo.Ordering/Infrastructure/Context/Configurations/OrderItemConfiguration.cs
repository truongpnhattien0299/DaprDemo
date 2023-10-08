using DaprDemo.Ordering.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DaprDemo.Ordering.Infrastructure.Context.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItems");
            builder.HasKey(orderItem => orderItem.Id);
            builder.Property(orderItem => orderItem.ProductId)
                .IsRequired();
            builder.Property(orderItem => orderItem.Quantity)
                .IsRequired();

            builder.HasOne(orderItem => orderItem.Order)
                .WithMany()
                .HasForeignKey(orderItem => orderItem.OrderId);

        }
    }
}
