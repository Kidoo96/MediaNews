using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MediaNews.Models
{
    public class NewsModel: BaseModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }

        public string FrontImage { get; set; }
        public List<string> ImageList { get; set; }

        [Timestamp]
        public DateTime DateAdded { get { return DateTime.Now; } }
        [Required]
        public int CategoryModelID { get; set; }

    }
}