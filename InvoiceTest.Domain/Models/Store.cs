using System.Collections.Generic;

namespace InvoiceTest.Models
{
    public class Store : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}
