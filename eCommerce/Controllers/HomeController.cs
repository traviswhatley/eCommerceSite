using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace eCommerce.Controllers
{
    public class HomeController : BaseController
    { 
        public ActionResult Index()
        {
            
            
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View(db.Products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //GET
        public ActionResult Navigation()
        {
            return PartialView(db.Categories.Where(x=>x.ParentID == null));
        }
    }
}
