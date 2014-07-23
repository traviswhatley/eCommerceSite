using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    [MetadataType(typeof(ReviewValidation))]
    public partial class Review { }

    public class ReviewValidation
    {
        [Required, Display(Name="Name")]
        public string Username { get; set; }
        [Required, MaxLength(150)]
        public string Title { get; set; }
        [Required, DataType(DataType.MultilineText), MaxLength(1000)]
        public string Body { get; set; }
        [Required]
        public int Rating { get; set; }
    }
}