using DaprDemo.Inventory.Application.Interfaces;
using DaprDemo.Inventory.Domain;
using DaprDemo.Inventory.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace DaprDemo.Inventory.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly InventoryDbContext _context;
        private readonly DbSet<Product> _products;

        public ProductRepository(InventoryDbContext context)
        {
            _context = context;
            _products = _context.Set<Product>();
        }

        public async Task<List<Product>> GetAll()
        {
            return await _products.ToListAsync();
        }
    }
}