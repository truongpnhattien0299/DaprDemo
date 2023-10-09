using DaprDemo.Ordering.Application.Features.Order.AddOrder.Commands;
using DaprDemo.Ordering.Domain;

namespace DaprDemo.Ordering.Application.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order> SaveDbAsync(OrderCommand command);
    }
}