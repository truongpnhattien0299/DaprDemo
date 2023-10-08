using Dapr;
using DaprDemo.Ordering.Application.Features.Order.AddOrder.Commands;
using DaprDemo.Ordering.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DaprDemo.Ordering.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IMediator _mediator;

        private const string DAPR_PUBSUB_NAME = "eshopondapr-pubsub-kafka";

        public OrderController(ILogger<OrderController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [Topic(DAPR_PUBSUB_NAME, "checkout")]
        [Route("AddCart")]
        [HttpPost]
        public async Task<IActionResult> AddCart(List<AddOrderCommand> carts)
        {
            _logger.LogWarning("carts {@carts}", carts);
            var result = await _mediator.Send(carts.FirstOrDefault());

            return Ok();
        }
    }
}