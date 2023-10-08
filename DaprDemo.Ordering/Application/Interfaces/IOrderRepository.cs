using DaprDemo.Ordering.Application.Features.Order.AddOrder.Commands;

namespace DaprDemo.Ordering.Application.Interfaces
{
    public interface IOrderRepository
    {
        Task<bool> SaveDbAsync(OrderCommand command);
    }
}