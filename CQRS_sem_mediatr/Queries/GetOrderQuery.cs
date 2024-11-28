using CQRS_sem_mediatr.Models;
using Domain.Entities;
using System;

namespace CQRS_sem_mediatr.Queries
{
    public class GetOrderQuery : IQuery<CustomResult<Order>>
    {
        public Guid Id { get; set; }

        //public static implicit operator Order(GetOrderQuery query)
        //{
        //    return new Order(
        //        query.Id, query.CustomerName, query.Status, query.Date);
        //}

        //public static implicit operator GetOrderQuery(Order entity)
        //{
        //    return new GetOrderQuery()
        //    {
        //        Id = entity.Id,
        //        CustomerName = entity.CustomerName,
        //        Status = entity.Status,
        //        Date = entity.Date
        //    };
        //}
    }
}
