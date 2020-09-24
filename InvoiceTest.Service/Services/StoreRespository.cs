using InvoiceTest.Data;
using InvoiceTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceTest.Service
{
   public  class StoreRespository : Repository<Models.Store>, IStoreRepository
    {
        public StoreRespository(InvoiceContext invoiceContext) : base(invoiceContext)
        {

        }
    }
}
