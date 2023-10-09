using DaprDemo.Ordering.Application.Interfaces;
using MediatR;

namespace DaprDemo.Ordering.Application.Features.Order.AddOrder.Commands
{
    public class AddOrderHandler : IRequestHandler<OrderCommand, object>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderItemRepository _orderItemRepository;
        // private readonly IMediator _mediator;

        public AddOrderHandler(
            IOrderRepository orderRepository,
            IOrderItemRepository orderItemRepository
            // IMediator mediator
            )
        {
            _orderRepository = orderRepository;
            _orderItemRepository = orderItemRepository;
            // _mediator = mediator;
        }

        public async Task<object> Handle(OrderCommand command, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.SaveDbAsync(command);
            // var orderItemsCommand = command?.OrderItems?.Select(x => { x.OrderId = order.Id; return x; }).ToList();
            // var orderItems = await _orderItemRepository.SaveDbAsync(orderItemsCommand);
            return order;
        }
    }
}