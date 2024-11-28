using Domain.Entities;
using Domain.Models;
using MediatR;
using System;

namespace Domain.Commands
{
    public class AddProductCommand : IRequest<CustomResult<Product>>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
