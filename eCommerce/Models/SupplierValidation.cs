using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    [MetadataType(typeof(SupplierValidation))]
    public partial class Supplier { }

    public class SupplierValidation
    {
        [Required]
        public int SuppliersID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, MaxLength(500), DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}