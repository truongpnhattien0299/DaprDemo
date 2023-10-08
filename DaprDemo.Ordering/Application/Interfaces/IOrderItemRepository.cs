using DaprDemo.Ordering.Application.Features.Order.AddOrder.Commands;

namespace DaprDemo.Ordering.Application.Interfaces
{
    public interface IOrderItemRepository
    {
        Task<bool> SaveDbAsync(OrderItemCommand command);
    }
}