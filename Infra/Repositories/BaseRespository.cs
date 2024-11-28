﻿using Domain.Entities;
using System.Collections.Generic;

namespace Infra.Repositories
{
    public class BaseRespository
    {
        public List<Order> Orders { get; set; }

        public BaseRespository()
        {
            Orders = new List<Order>();
        }
    }
}
