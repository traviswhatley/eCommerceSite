using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    [MetadataType(typeof(ProductValidation))]
    public partial class Product { }

    public class ProductValidation
    {
        [Display(Name="Supplier")]
        public int SupplierID { get; set; }
        [Display(Name="Category")]
        public int CatergoryID { get; set; }
        [Required, MaxLength(150)]
        public string Name { get; set; }
        [Required, DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required, DataType(DataType.Currency)]
        public decimal UnitPrice { get; set; }
        [Required, DataType(DataType.Currency)]
        public decimal ListPrice { get; set; }
        [Required]
        public bool InStock { get; set; }
    }
}