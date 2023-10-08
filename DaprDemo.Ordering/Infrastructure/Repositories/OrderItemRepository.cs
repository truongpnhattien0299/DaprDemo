using DaprDemo.Ordering.Application.Features.Order.AddOrder.Commands;
using DaprDemo.Ordering.Application.Interfaces;
using DaprDemo.Ordering.Domain;
using DaprDemo.Ordering.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace DaprDemo.Ordering.Infrastructure.Repositories
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly OrderingDbContext _context;
        private DbSet<OrderItem> _orderItems;

        public OrderItemRepository(OrderingDbContext context)
        {
            _context = context;
            _orderItems = _context.OrderItems;
        }

        public async Task<bool> SaveDbAsync(OrderItemCommand command)
        {
            OrderItem orderItem = new(0, command.ProductId, command.Quantity, command.OrderId);
            await _orderItems.AddAsync(orderItem);
            return (await _context.SaveChangesAsync()) > 0;

        }
    }
}