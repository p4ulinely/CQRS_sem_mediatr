using Domain.Models;
using Domain.Entities;
using System;

namespace Domain.Queries
{
    public class GetOrderQuery : IQuery<CustomResult<Order>>
    {
        public Guid Id { get; set; }

    }
}
