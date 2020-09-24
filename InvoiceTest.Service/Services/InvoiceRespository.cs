using InvoiceTest.Data;
using InvoiceTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceTest.Service
{
   public  class InvoiceRespository : Repository<Models.Invoice>, IInvoiceRepository
    {
        public InvoiceRespository(InvoiceContext invoiceContext) : base(invoiceContext)
        {

        }
    }
}
