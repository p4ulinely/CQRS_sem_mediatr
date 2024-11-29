using Domain.Entities;
using System.Threading.Tasks;
using System;
using Domain.Repositories;

namespace CQRS_sem_mediatr.Services
{
    public class OrderService: IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Task Add(Order order)
            => _orderRepository.Add(order);

        public async Task<Order> GetOrderByIdAsync(Guid id)
            => await _orderRepository.GetByIdAsync(id);
    }
}
