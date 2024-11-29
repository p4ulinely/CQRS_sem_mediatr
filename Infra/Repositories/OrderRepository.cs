using Domain.Entities;
using Domain.Repositories;
using System;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class OrderRepository : BaseRespository, IOrderRepository
    {
        public Task Add(Order order)
        {
            Orders.Add(order);

            return Task.CompletedTask;
        }

        public Task<Order> GetByIdAsync(Guid id)
        {
            return Task.FromResult(Orders.Find(x => x.Id == id));
        }
    }
}
