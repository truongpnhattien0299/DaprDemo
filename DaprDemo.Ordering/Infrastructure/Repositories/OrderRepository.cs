using DaprDemo.Ordering.Application.Features.Order.AddOrder.Commands;
using DaprDemo.Ordering.Application.Interfaces;
using DaprDemo.Ordering.Domain;
using DaprDemo.Ordering.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace DaprDemo.Ordering.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderingDbContext _context;
        private DbSet<Order> _orders;

        public OrderRepository(OrderingDbContext context)
        {
            _context = context;
            _orders = _context.Orders;
        }

        public async Task<Order> SaveDbAsync(OrderCommand command)
        {
            Order order = new(0, command.UserId ?? string.Empty);
            order.OrderItems = command.OrderItems;
            await _orders.AddAsync(order);
            await _context.SaveChangesAsync();
            return order;

        }
    }
}