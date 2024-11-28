using CQRS_sem_mediatr.Models;
using CQRS_sem_mediatr.Queries;
using CQRS_sem_mediatr.Services;
using Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_sem_mediatr.QueriesHandlers
{
    public class GetOrderQueryHandler : IQueryHandler<GetOrderQuery, CustomResult<Order>>
    {
        private readonly IOrderService _orderService;

        public GetOrderQueryHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<CustomResult<Order>> Handle(GetOrderQuery query, CancellationToken cancellationToken)
        {
            try
            {
                var order = await _orderService.GetOrderByIdAsync(query.Id);

                if (order is null)
                    return new CustomResult<Order>(false, "Pedido não encontrado", default);

                return new CustomResult<Order>(data: order);
            }
            catch (Exception ex)
            {
                return new CustomResult<Order>(false, ex.Message, default);
            }
        }
    }
}
