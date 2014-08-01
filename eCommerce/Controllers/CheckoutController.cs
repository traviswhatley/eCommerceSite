using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    public class CheckoutController : BaseController
    {
        //
        // GET: /Checkout/

        public ActionResult Index()
        {
            return RedirectToAction("BillingAddress", "Checkout");
        }

        [HttpGet]
        public ActionResult BillingAddress()
        {
            return View(this.MyOrder.BillingAddress);
        }

        [HttpPost]
        public ActionResult BillingAddress(Models.Address address)
        {
            db.Addresses.Add(address);
            db.SaveChanges();
            return View("ShippingAddress", "Checkout");
        }

        [HttpGet]
        public ActionResult ShippingAddress()
        {
            return View(this.MyOrder.ShippingAddress);
        }

        [HttpPost]
        public ActionResult ShippingAddress(Models.Address address)
        {
            db.Addresses.Add(address);
            db.SaveChanges();
            return View("Payment", "Checkout");
        }

        [HttpGet]
        public ActionResult Payment()
        {
            return View(this.MyOrder.Payment);
        }

        [HttpPost]
        public ActionResult Payment(Models.Payment payment)
        {
            db.Payments.Add(payment);
            db.SaveChanges();
            return View("Index", "Home");
        }

    }
}
