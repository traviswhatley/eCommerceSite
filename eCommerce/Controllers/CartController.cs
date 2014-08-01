using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    public class CartController : BaseController
    {
        //
        // GET: /Cart/
        public ActionResult Index()
        {
            return View(this.MyOrder.OrderLines.OrderBy(x=>x.UnitPrice));
        }

        //GET /Cart/MiniCart
        [HttpGet]
        public ActionResult MiniCart()
        {
            //returns a partial view for use in the header
            return PartialView(this.MyOrder);
        }

        [HttpPost]
        public ActionResult Add(Models.OrderLine ol)
        {
            if (this.MyOrder.OrderLines.Where(x => x.ProductID == ol.ProductID).Any())
            {
                var cartItem = this.MyOrder.OrderLines.Where(x => x.ProductID == ol.ProductID).First();
                cartItem.Qty += ol.Qty;
            }
            else
            {
                this.MyOrder.OrderLines.Add(ol);
            }
            db.SaveChanges();
            return RedirectToAction("MiniCart", "Cart");
        }

        [HttpGet]
        public ActionResult Remove(int id)
        {
            var toDelete = MyOrder.OrderLines.Where(x => x.ProductID == id).First();
            db.OrderLines.Remove(toDelete);
            return View("Remove", "Cart");
        }
    }
}
