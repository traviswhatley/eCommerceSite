using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    public class BaseController : Controller
    {
        //property to get our order
        private Models.Order _myOrder;
        public Models.Order MyOrder
        {
            get
            {
                //see if _myOrder is null
                if (_myOrder == null)
                {
                    //get order from the db
                    _myOrder = db.Orders.Find(GetOrderID());

                }
                return _myOrder;
            }
        }

        //set up a db connection
        public Models.eCommerceEntities db = new Models.eCommerceEntities();

        //get orderID
        public int GetOrderID()
        {
            if (Session["orderID"] == null)
            {
                //they don't have an orderID
                //create a new order
                Models.Order order = new Models.Order();
                //fill in required info
                order.DateCreated = DateTime.Now;
                order.Status = "Cart";
                order.Tax = 0;
                order.Total = 0;
                order.ShippingTotal = 0;
                //add order to the db
                db.Orders.Add(order);
                //save
                db.SaveChanges();
                //set the session variable for the orderID
                Session["orderID"] = order.OrderID;
            }
            //convert the session object to a string then to an integer
            return int.Parse(Session["orderID"].ToString());
        }
    }
}
