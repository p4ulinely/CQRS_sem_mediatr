using CQRS_sem_mediatr.Commands;
using CQRS_sem_mediatr.Models;
using CQRS_sem_mediatr.Services;
using Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_sem_mediatr.CommandsHandlers
{
    public class AddOrderCommandHandler : ICommandHandler<AddOrderCommand, CustomResult<AddOrderCommand>>
    {
        private readonly IOrderService _orderService;

        public AddOrderCommandHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public Task<CustomResult<AddOrderCommand>> Handle(AddOrderCommand command, CancellationToken cancellationToken)
        {
            Order order = command;

            try
            {
                order.Validate();

                // para simulacao da geracao de um id
                var guid = Guid.NewGuid();
                order.SetId(guid);

                _orderService.Add(order);
            }
            catch (Exception ex)
            {
                return Task.FromResult(new CustomResult<AddOrderCommand>(false, ex.Message, order));
            }

            return Task.FromResult(new CustomResult<AddOrderCommand>(data: order));
        }
    }
}
