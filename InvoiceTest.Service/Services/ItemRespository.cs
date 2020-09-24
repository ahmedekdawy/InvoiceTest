using InvoiceTest.Data;
using InvoiceTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceTest.Service
{
   public  class ItemRespository : Repository<Models.Item>, IItemRepository
    {
        public ItemRespository(InvoiceContext invoiceContext) : base(invoiceContext)
        {

        }
    }
}
