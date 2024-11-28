using Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IOrderRepository
    {
        Task Add(Order order);
        Task<Order> GetOrderByIdAsync(Guid id);
    }
}
