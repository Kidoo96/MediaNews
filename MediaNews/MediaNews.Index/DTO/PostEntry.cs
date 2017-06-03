using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNews.DTO
{
    public class PostEntry
    {

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Описание")]
        public string Content { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Линк към външен пост")]
        public string ExternalUrl { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Снимка")]
        public string ImgUrl { get; set; }

        [Required]
        public string CategoryId { get; set; }

    }
}
