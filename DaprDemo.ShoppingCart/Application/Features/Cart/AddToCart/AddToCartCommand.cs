using MediatR;

namespace DaprDemo.ShoppingCart.Application.Features.Cart.AddToCart
{
    public class AddToCartCommand : IRequest<object>
    {
        public string? UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}