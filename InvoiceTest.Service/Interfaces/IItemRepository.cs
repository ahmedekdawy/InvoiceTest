﻿using InvoiceTest.Data;
using InvoiceTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceTest.Service
{
    public interface IItemRepository : IRepository<Models.Item>
    {
    }
}