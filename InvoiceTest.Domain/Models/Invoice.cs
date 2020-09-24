
using System;
using System.Collections.Generic;

namespace InvoiceTest.Models
{
    public class Invoice: BaseEntity
    {
        public string  InvoiceNo { get; set; }
        public DateTime Date { get; set; }
        public int StoreId { get; set; }
        public string Total { get; set; }
        public string Taxes { get; set; }
        public string Net { get; set; }
        public ICollection<InvoiceDetail> Invoices { get; set; }
    }
}
