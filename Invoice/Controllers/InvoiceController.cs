using InvoiceTest.Model;
using InvoiceTest.Models;
using InvoiceTest.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InvoiceTest.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IInvoiceRepository invoice;
        private readonly IItemRepository item;
        private readonly IStoreRepository store;
        private readonly IUnitRepository unit;

        public InvoiceController(IInvoiceRepository invoice,IItemRepository item,IStoreRepository store,IUnitRepository unit   )
        {
            this.invoice = invoice;
            this.item = item;
            this.store = store;
            this.unit = unit;
        }
        // GET: InvoiceController
        [Route("/invoice/index")]
        public ActionResult Index()
        {
            var invoices = invoice.GetAll().ToList();
            return View(invoices);
        }


        // GET: InvoiceController/Details/5
        public ActionResult Details(int id)
        {
            var invoices = invoice.Get(id);
            return View();
        }
        [Route("/invoice/Create")]
        // GET: InvoiceController/Create
        public ActionResult Create()
        {
          
            ViewBag.ItemsList =  new SelectList(item.GetAll(), "Id", "Name",false);
            ViewBag.UnitsList = new SelectList(unit.GetAll(), "Id", "Name", false);
            ViewBag.StoresList = new SelectList(store.GetAll(), "Id", "Name", false);

            return View(new InvoiceModel());
        }

        // POST: InvoiceController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        [Route("/invoice/Create")]
        public ActionResult Create(Invoice inv)
        {
            try
            {
                inv.AddedDate = DateTime.Now;
                invoice.Insert(inv);
                invoice.SaveChanges();
                return RedirectToAction(nameof(Create));
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: InvoiceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InvoiceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InvoiceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InvoiceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/invoice/delete")]
        public ActionResult Delete(string InvoiceNo)
        {
            try
            {
               var inv= invoice.GetAll().Where(w => w.InvoiceNo == InvoiceNo).FirstOrDefault();
                if (inv != null)
                {
                    invoice.Delete(inv);
                    invoice.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
