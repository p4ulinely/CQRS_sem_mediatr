using Domain.Entities;
using System.Threading.Tasks;
using System;

namespace CQRS_sem_mediatr.Services
{
    public interface IOrderService
    {
        Task Add(Order order);
        Task<Order> GetOrderByIdAsync(Guid id);
    }
}
