using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaNews.Models
{
    public class CategoryModel: BaseModel
    {

        public string Name { get; set; }
        public string slugName { get; set; }

    }
}