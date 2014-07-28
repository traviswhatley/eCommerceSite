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
            return View();
        }

        //GET /Cart/MiniCart
        public ActionResult MiniCart()
        {
            //returns a partial view for use in the header
            return PartialView(this.MyOrder);
        }

        [HttpPost]
        public ActionResult Add()
        {
            return PartialView(this.MyOrder);
        }

        [HttpGet]
        public ActionResult Remove(int id)
        {
            Models.Product remove = db.Products.Find(id);
            return RedirectToAction("Index", "Cart");
        }
    }
}
