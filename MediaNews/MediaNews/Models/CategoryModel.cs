using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public ICollection<Article> Articles { get; set; }


    }
}