using DaprDemo.ShoppingCart.Application.Interfaces;
using MediatR;

namespace DaprDemo.ShoppingCart.Application.Features.Cart.AddToCart
{
    public class AddToCartHandler : IRequestHandler<AddToCartCommand, object>
    {
        private readonly ICartRepository _cartRepository;

        public AddToCartHandler(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public async Task<object> Handle(AddToCartCommand request, CancellationToken cancellationToken)
        {
            return await _cartRepository.AddProductToCart(request);
        }
    }
}