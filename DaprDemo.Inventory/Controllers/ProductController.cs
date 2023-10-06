using DaprDemo.Inventory.Application.Features.Products.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DaprDemo.Inventory.Controllers
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

        // GET: api/<controller>
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            return Ok(await _mediator.Send(new GetAllProductQuery()));
        }

    }
}