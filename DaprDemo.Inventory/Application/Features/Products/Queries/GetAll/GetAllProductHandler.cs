using DaprDemo.Inventory.Application.Interfaces;
using MediatR;

namespace DaprDemo.Inventory.Application.Features.Products.Queries.GetAll
{
    public class GetAllProductHandler : IRequestHandler<GetAllProductQuery, object>
    {
        private readonly IProductRepository _productRepository;

        public GetAllProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<object> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetAll();
        }
    }
}