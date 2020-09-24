using InvoiceTest.Data;
using InvoiceTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceTest.Service
{
   public  class UnitRespository : Repository<Models.Unit>, IUnitRepository
    {
        public UnitRespository(InvoiceContext invoiceContext) : base(invoiceContext)
        {

        }
    }
}
