using Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IProductRepository
    {
        Task Add(Product product);
        Task<Product> GetByIdAsync(Guid id);
    }
}
