using InvoiceTest.Models;
using Microsoft.EntityFrameworkCore;

namespace InvoiceTest
{
    public class InvoiceContext:DbContext
    {
        public InvoiceContext(DbContextOptions<InvoiceContext> options) : base(options)
        { }
        public DbSet<Item> Items { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=EKDAWY-PC\MSSQLSERVER1;Initial Catalog=Invoice;Integrated Security=True");
        //}
    }
}
