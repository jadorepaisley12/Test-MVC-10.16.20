using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTest.DATA.EF//.Metadata
{
    [MetadataType(typeof(ToDoItemMetadata))]
    public partial class ToDoItem { }

    public class ToDoItemMetadata
    {
        //public int Id { get; set; }
        [Required]
        [Display(Name = "To Do")]
        public string ToDoText { get; set; }


        public int CategoryId { get; set; }
    }

    [MetadataType(typeof(CategoryMetadata))]
    public partial class Category { }


    public class CategoryMetadata
    {
        //public int CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Category")]
        public string CategoryText { get; set; }
    }

}
