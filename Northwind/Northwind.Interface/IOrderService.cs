﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface IOrderService : IGenericServise<Order,DtoOrder>
    {
        IQueryable OrderReport(int orderId);

    }
}
