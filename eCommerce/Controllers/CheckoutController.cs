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
            return RedirectToAction("BillingAddress");
        }

        [HttpGet]
        public ActionResult BillingAddress()
        {
            if (this.MyOrder.BillingAddress == null)
            {
                return View(this.MyOrder.BillingAddress);
            }
            return RedirectToAction("Review");
        }

        [HttpPost]
        public ActionResult BillingAddress(Models.Address address)
        {
            //db.Addresses.Add(address);
            //db.SaveChanges();
            this.MyOrder.BillingAddress = address;
            db.SaveChanges();
            return RedirectToAction("ShippingAddress");
        }

        [HttpGet]
        public ActionResult ShippingAddress()
        {
            if (this.MyOrder.ShippingAddress == null)
            {
                return View(this.MyOrder.ShippingAddress);    
            }
            return RedirectToAction("Review");
        }

        [HttpPost]
        public ActionResult ShippingAddress(Models.Address address)
        {
            //db.Addresses.Add(address);
            //db.SaveChanges();
            this.MyOrder.ShippingAddress = address;
            db.SaveChanges();
            return RedirectToAction("Payment");
        }

        [HttpGet]
        public ActionResult Payment()
        {
            if (this.MyOrder.Payment == null)
            {
                return View(this.MyOrder.Payment);    
            }
            else
            {
                return View("Payment");
            }
            return RedirectToAction("Review");
        }

        [HttpPost]
        public ActionResult Payment(Models.Payment payment)
        {
            //db.Payments.Add(payment);
            //db.SaveChanges();
            this.MyOrder.Payment = payment;
            db.SaveChanges();
            return RedirectToAction("Review");
        }

        [HttpGet]
        public ActionResult Review()
        {
            return View(this.MyOrder);
        }

    }
}
