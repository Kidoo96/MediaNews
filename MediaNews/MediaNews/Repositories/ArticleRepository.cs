using MediaNews.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MediaNews.Repositories
{
    public class ArticleRepository : BaseRepository<Article>
    {
        public ArticleRepository() : base()
        {

        }

    }
}