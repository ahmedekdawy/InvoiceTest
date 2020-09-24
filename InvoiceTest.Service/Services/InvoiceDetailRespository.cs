using InvoiceTest.Data;
using InvoiceTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceTest.Service
{
   public  class InvoiceDetailRespository : Repository<Models.InvoiceDetail>, IInvoiceDetailRepository
    {
        public InvoiceDetailRespository(InvoiceContext invoiceContext) : base(invoiceContext)
        {

        }
    }
}
