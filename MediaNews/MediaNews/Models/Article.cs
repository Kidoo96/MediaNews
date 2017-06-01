using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaNews.Models
{
    public class Article: BaseModel
    {
        [Required]
        [StringLength(255)]
        [Display(Name = "Заглавие")]
        public string Title { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Кратко описание")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Описание")]
        public string Content { get; set; }

        [Required]
        [Display(Name = "Снимка")]
        public byte[] imagePath { get; set; }

        private DateTime dateCreated = DateTime.Now;
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата на създаване")]
        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }

        [Display(Name = "Категория")]
        public int CategoryModelsID { get; set; }

        [ForeignKey("CategoryModelsID")]
        public CategoryModel Categoryes { get; set; }

    }
}