using DaprDemo.Ordering.Application.Interfaces;
using MediatR;

namespace DaprDemo.Ordering.Application.Features.Order.AddOrder.Commands
{
    public class AddOrderItemHandler : IRequestHandler<OrderItemCommand, object>
    {
        private readonly IOrderItemRepository _orderItemRepository;

        public AddOrderItemHandler(IOrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }

        public async Task<object> Handle(OrderItemCommand command, CancellationToken cancellationToken)
        {
            var order = await _orderItemRepository.SaveDbAsync(command);
            return order;
        }
    }
}