using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaNews.Models
{
    public class NewsModel: BaseModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string FrontImage { get; set; }
        public List<string> ImageList { get; set; }
        public DateTime DateAdded { get; set; }
        public new CategoryModel ID { get; set; }

    }
}