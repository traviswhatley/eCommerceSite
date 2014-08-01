using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    [MetadataType(typeof(CheckoutValidation))]
    public partial class Checkout { }
    public class CheckoutValidation
    {
        public Nullable<int> BillingAddressID { get; set; }
        public Nullable<int> ShippingAddressID { get; set; }
        public virtual Address BillingAddress { get; set; }
        public virtual Address ShippingAddress { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        public virtual Payment Payment { get; set; }
    }
}