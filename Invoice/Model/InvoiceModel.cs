using InvoiceTest.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceTest.Model
{
    public class InvoiceModel:Invoice
    {
        public List<SelectListItem> ItemsList { get; set; }
        public List<SelectListItem> UnitsList { get; set; }
        public List<SelectListItem> StoreList { get; set; }
        public List<SelectListItem> Glossary_List { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
