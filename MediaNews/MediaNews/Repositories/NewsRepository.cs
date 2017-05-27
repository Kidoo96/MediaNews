using MediaNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaNews.Repositories
{
    public class NewsRepository: BaseRepository<NewsModel>
    {
        public NewsRepository(): base()
        {

        }
    }
}