using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MediaNews.Models
{
    public class CategoryModel: BaseModel
    {
        [Required]
        [StringLength(80)]
        [Display(Name = "Име на категорията")]
        public string Name { get; set; }


    }
}