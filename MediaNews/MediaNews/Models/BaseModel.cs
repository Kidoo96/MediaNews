using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MediaNews.Models
{
    public class BaseModel
    {
        [Key]
        public virtual int ID { get; set; }
    }
}