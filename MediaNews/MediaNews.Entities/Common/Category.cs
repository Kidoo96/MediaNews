﻿using Project.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNews.Entities.Common
{
    public sealed class Category
    {
        public Category()
        {  }

        public Category(string name, CustomId id = null) : this(id)
        {
            this.Name = name;
        }

        public Category(CustomId id)
        {
            this.Id = string.IsNullOrEmpty(Convert.ToString(id)) ? new CustomId().ToString() : id.ToString();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Категория")]
        public string Name { get; set; }
    }
}
