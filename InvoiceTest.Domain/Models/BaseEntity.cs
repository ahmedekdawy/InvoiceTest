using System;

namespace InvoiceTest.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
