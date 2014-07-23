using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //add using for data annotations

namespace eCommerce.Models
{
    [MetadataType(typeof(CategoryValidation))] //step 3: add metadata
    public partial class Category //step 2: create partial class for metadata
    {
        //step 1: empty
    }

    public class CategoryValidation
    {
        //get properties from .edmx > .tt file
        [Display(Name="Parent Category")]
        public Nullable<int> ParentID { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
    }
}