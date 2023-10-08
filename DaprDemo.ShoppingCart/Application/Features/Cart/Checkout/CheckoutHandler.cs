using DaprDemo.ShoppingCart.Application.Interfaces;
using MediatR;

namespace DaprDemo.ShoppingCart.Application.Features.Cart.Checkout
{
    public class CheckoutHandler : IRequestHandler<CheckoutCommand, object>
    {
        private readonly ICartRepository _cartRepository;

        public CheckoutHandler(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public string? UserId { get; set; }
        public async Task<object> Handle(CheckoutCommand command, CancellationToken cancellationToken)
        {
            var result = await _cartRepository.Checkout(command);
            return result;
        }
    }
}