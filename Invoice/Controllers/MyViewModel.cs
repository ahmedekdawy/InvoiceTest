using InvoiceTest.Models;

namespace InvoiceTest.Controllers
{

    public class MyViewModel : InvoiceDetail
    {
        public int EmployeeId { get; set; }
        public string Comments { get; set; }
        public System.Collections.Generic.List<Employee> EmployeesList { get; set; }
    }
        public class Employee
        {
            public int Id { get; set; }
            public string FullName { get; set; }
        }
    }
