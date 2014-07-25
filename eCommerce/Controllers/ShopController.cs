using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace eCommerce.Controllers
{
    public class ShopController : Controller
    {
        Models.eCommerceEntities db = new Models.eCommerceEntities();
        //
        // GET: /Shop/

        public ActionResult Index()
        {
            return View(db.Products.OrderBy(x=>x.ProductID));
        }

        [HttpGet]
        public ActionResult ByProduct(int id = 0)
        {
            Models.Product productToFind = db.Products.Find(id);
            return View(productToFind);
        }

    }
}
