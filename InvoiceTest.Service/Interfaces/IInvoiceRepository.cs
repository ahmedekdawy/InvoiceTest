﻿using InvoiceTest.Data;
using InvoiceTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceTest.Service
{
    public interface IInvoiceRepository: IRepository<Models.Invoice>
    {
    }
}
