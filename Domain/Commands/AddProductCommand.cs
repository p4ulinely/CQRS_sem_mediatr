using Domain.Entities;
using Domain.Models;
using MediatR;
using System;

namespace Domain.Commands
{
    public class AddProductCommand : IRequest<CustomResult<Product>>
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

        public static implicit operator Product(AddProductCommand command)
        {
            return new Product(command.Id, command.Description);
        }

        //public static implicit operator AddProductCommand(Product entity)
        //{
        //    return new AddProductCommand()
        //    {
        //        Id = entity.Id,
        //        Description = entity.Description
        //    };
        //}
    }
}
