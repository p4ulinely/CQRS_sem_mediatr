using Domain.Entities;
using Domain.Repositories;
using System;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class ProductRepository : BaseRespository, IProductRepository
    {
        public Task Add(Product product)
        {
            Products.Add(product);

            return Task.CompletedTask;
        }

        public Task<Product> GetByIdAsync(Guid id)
        {
            return Task.FromResult(Products.Find(x => x.Id == id));
        }
    }
}
