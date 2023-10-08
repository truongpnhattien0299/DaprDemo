using Dapr;
using DaprDemo.Ordering.Domain;
using Microsoft.AspNetCore.Mvc;

namespace DaprDemo.Ordering.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;

        private const string DAPR_PUBSUB_NAME = "eshopondapr-pubsub-kafka";

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [Topic(DAPR_PUBSUB_NAME, "checkout")]
        [Route("AddCart")]
        [HttpPost]
        public IActionResult AddCart(string carts)
        {
            var cart = carts;
            _logger.LogWarning("carts {@carts}", carts.FirstOrDefault());
            Console.WriteLine($"New product has been added into shopping cart. Product Id: cart");

            return Ok(carts);
        }
    }
}