using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MediaNews.Index.DTO
{
    public class CommentEntry
    {

        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }

        [Required]
        [StringLength(155)]
        public string Comment { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

    }
}