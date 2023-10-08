using MediatR;

namespace DaprDemo.ShoppingCart.Application.Features.Cart.Checkout
{
    public class CheckoutCommand : IRequest<object>
    {
        public string? UserId { get; set; }

    }
}