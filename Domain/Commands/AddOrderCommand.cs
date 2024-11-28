using Domain.Entities;
using Domain.Models;
using System;

namespace Domain.Commands
{
    public class AddOrderCommand : ICommand<CustomResult<AddOrderCommand>>
    {
        public Guid Id { get; set; }
        public string CustomerName { get; set; }
        public int Status { get; set; }
        public DateTime Date { get; set; }

        public static implicit operator Order(AddOrderCommand command)
        {
            return new Order(
                command.Id, command.CustomerName, command.Status, command.Date);
        }

        public static implicit operator AddOrderCommand(Order entity)
        {
            return new AddOrderCommand()
            {
                Id = entity.Id,
                CustomerName = entity.CustomerName,
                Status = entity.Status,
                Date = entity.Date
            };
        }
    }
}
