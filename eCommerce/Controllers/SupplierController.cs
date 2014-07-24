using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    public class SupplierController : Controller
    {
        Models.eCommerceEntities db = new Models.eCommerceEntities();
        //
        // GET: /Supplier/

        public ActionResult Index()
        {
            return View(db.Suppliers.OrderBy(x=>x.Name));
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Models.Supplier());
        }

        [HttpPost]
        public ActionResult Create(Models.Supplier supplier)
        {
            db.Suppliers.Add(supplier);
            db.SaveChanges();
            return RedirectToAction("Index", "Suppliers");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Models.Supplier supplierDelete = db.Suppliers.Find(id);
            return View(supplierDelete);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            Models.Supplier supplierDelete = db.Suppliers.Find(id);
            db.Suppliers.Remove(supplierDelete);
            db.SaveChanges();
            
            return RedirectToAction("Index", "Suppliers");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Models.Supplier supplierEdit = new Models.Supplier();
            return View(supplierEdit);
        }

        [HttpPost]
        public ActionResult Edit(Models.Supplier supplierEdit)
        {
            db.Entry(supplierEdit).State = System.Data.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index", "Supplier");
        }

        public ActionResult Detail(int id)
        {
            Models.Supplier supplier = db.Suppliers.Find(id);
            return View(supplier);
        }
    }
}
