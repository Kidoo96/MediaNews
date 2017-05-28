using MediaNews.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MediaNews
{
    public class NewsContext: DbContext
    {
        public NewsContext()
            : base("MediaNews-Miroslav")
        {

        }

        public DbSet<NewsModel> News { get; set; }
        public DbSet<CategoryModel> Categoryes { get; set; }


    }
}