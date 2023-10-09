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

        // public async Task<List<OrderItemCommand>> SaveDbAsync(List<OrderItemCommand> command)
        // {
        //     foreach (var item in command)
        //     {
        //         OrderItem orderItem = new(0, item.ProductId, item.Quantity, item.OrderId);
        //         await _orderItems.AddAsync(orderItem);
        //     }
        //     await _context.SaveChangesAsync();
        //     return command;

        // }
        public async Task<List<OrderItem>> SaveDbAsync(List<OrderItem> command)
        {
            foreach (var item in command)
            {
                OrderItem orderItem = new(0, item.ProductId, item.Quantity, item.OrderId);
                await _orderItems.AddAsync(orderItem);
            }
            await _context.SaveChangesAsync();
            return command;

        }
    }
}