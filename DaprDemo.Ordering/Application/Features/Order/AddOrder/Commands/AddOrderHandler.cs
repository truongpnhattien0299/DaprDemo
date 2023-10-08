using DaprDemo.Ordering.Application.Interfaces;
using MediatR;

namespace DaprDemo.Ordering.Application.Features.Order.AddOrder.Commands
{
    public class AddOrderHandler : IRequestHandler<OrderCommand, object>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMediator _mediator;

        public AddOrderHandler(IOrderRepository orderRepository, IMediator mediator)
        {
            _orderRepository = orderRepository;
            _mediator = mediator;
        }

        public async Task<object> Handle(OrderCommand command, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.SaveDbAsync(command);

            return order;
        }
    }
}