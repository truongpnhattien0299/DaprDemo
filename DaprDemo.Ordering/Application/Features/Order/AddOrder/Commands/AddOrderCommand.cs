using DaprDemo.Ordering.Domain;
using MediatR;

namespace DaprDemo.Ordering.Application.Features.Order.AddOrder.Commands
{
    public class AddOrderCommand : IRequest<object>
    {
        public string? UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }

    public class OrderCommand : IRequest<object>
    {
        public string? UserId { get; set; }
        public List<OrderItem>? OrderItems { get; set; }
    }
}