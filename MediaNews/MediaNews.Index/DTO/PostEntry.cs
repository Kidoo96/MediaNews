using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNews.Index.DTO
{
    public class PostEntry
    {

        [Required]
        [StringLength(255)]
        [Display(Name = "Заглавие")]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Кратко описание")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Описание")]
        public string Content { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Снимка")]
        public string ImgUrl { get; set; }

        [Required]
        [Display(Name = "Категория")]
        public string CategoryId { get; set; }

    }
}
