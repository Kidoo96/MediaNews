using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaNews.Models
{
    public class ArticleCategoryVM
    {
        public Article Article { get; set; }
        public IEnumerable<CategoryModel> Categories { get; set; }
    }
}