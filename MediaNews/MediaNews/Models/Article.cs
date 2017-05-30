using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MediaNews.Models
{
    public class Article: BaseModel
    {
        [Required]
        [StringLength(255)]
        [Display(Name = "Заглавие")]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Описание")]
        public string Content { get; set; }

        [Required]
        [Display(Name = "Снимка")]
        public string imagePath { get; set; }

        private DateTime dateCreated = DateTime.Now;
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата на създаване")]
        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }

        //[Required]
        //[Display(Name = "Категория")]
        //public virtual CategoryModel Category { get; set; }


    }
}