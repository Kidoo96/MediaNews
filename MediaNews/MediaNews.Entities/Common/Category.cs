using Project.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNews.Entities.Common
{
    public sealed class Category
    {
        public Category()
        {  }

        public Category(string name, string color, CustomId id = null) : this(id)
        {
            this.Name = name;
            this.catColor = color;
        }

        public Category(CustomId id)
        {
            this.Id = string.IsNullOrEmpty(Convert.ToString(id)) ? new CustomId().ToString() : id.ToString();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Категория")]
        public string Name { get; set; }

        [DisplayFormat(NullDisplayText = "#001f3f", ApplyFormatInEditMode = true)]
        [Display(Name = "Цвят на категорията")]
        public string catColor { get; set; }
    }
}
