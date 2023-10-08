using DaprDemo.ShoppingCart.Application.Features.Cart.AddToCart;
using DaprDemo.ShoppingCart.Application.Features.Cart.Checkout;

namespace DaprDemo.ShoppingCart.Application.Interfaces
{
    public interface ICartRepository
    {
        Task<List<AddToCartCommand>> GetCart(string userId);
        // Task<AddToCartCommand> AddProductToCart(AddToCartCommand command);
        Task<List<AddToCartCommand>> AddProductToCart(AddToCartCommand command);
        Task<List<AddToCartCommand>> Checkout(CheckoutCommand command);
    }
}