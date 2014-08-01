using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace eCommerce.Controllers
{
    public class ShopController : BaseController
    {
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

        [HttpPost]
        public ActionResult Search(string input)
        {
            return View(db.SearchProductsByName(input));
        }

        [HttpGet]
        public ActionResult ByCategory(int id)
        {
            Models.Category categoryToFind = db.Categories.Find(id);
            ViewBag.CategoryName = categoryToFind.Name;
            return View(db.FindParentProducts(id));
        }
    }
}
