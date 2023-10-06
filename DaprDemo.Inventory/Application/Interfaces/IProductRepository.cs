using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DaprDemo.Inventory.Domain;

namespace DaprDemo.Inventory.Application.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAll();
    }
}