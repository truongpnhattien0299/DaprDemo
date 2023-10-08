using DaprDemo.ShoppingCart.Application.Features.Cart.AddToCart;
using DaprDemo.ShoppingCart.Application.Features.Cart.Checkout;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DaprDemo.ShoppingCart.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddProductToCart([FromBody] AddToCartCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpPost("Checkout")]
        public async Task<IActionResult> Checkout([FromBody] CheckoutCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}