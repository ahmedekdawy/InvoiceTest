namespace InvoiceTest.Models
{
    public class InvoiceDetail : BaseEntity
    {
        public int InvoiceId { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public string Price { get; set; }
        public string QTY { get; set; }
        public string  Total { get; set; }
        public string  Discount { get; set; }
        public string Net { get; set; }
    }
}
