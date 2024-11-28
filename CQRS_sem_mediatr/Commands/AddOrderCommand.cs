using Domain.Entities;
using CQRS_sem_mediatr.Models;
using System;
using System.Text.Json.Serialization;

namespace CQRS_sem_mediatr.Commands
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
