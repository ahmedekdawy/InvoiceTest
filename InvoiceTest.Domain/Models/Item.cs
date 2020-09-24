using System.Collections.Generic;

namespace InvoiceTest.Models
{
    public class Item : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<InvoiceDetail> Invoices { get; set; }
    }
}
