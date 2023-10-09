using DaprDemo.Ordering.Application.Features.Order.AddOrder.Commands;
using DaprDemo.Ordering.Domain;

namespace DaprDemo.Ordering.Application.Interfaces
{
    public interface IOrderItemRepository
    {
        // Task<List<OrderItemCommand>> SaveDbAsync(List<OrderItemCommand> command);
        Task<List<OrderItem>> SaveDbAsync(List<OrderItem> command);
    }
}