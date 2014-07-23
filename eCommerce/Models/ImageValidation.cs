using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace eCommerce.Models
{
    [MetadataType(typeof(ImageValidation))]
    public partial class Image { }
    public class ImageValidation
    {
        [Display(Name="Product Name")]
        public int ProductID { get; set; }
        [Required, MaxLength(200)]
        public string ImageURL { get; set; }
        [Required, MaxLength(200)]
        public string Description { get; set; }
    
    }
}