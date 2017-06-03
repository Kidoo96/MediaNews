using MediaNews.Entities.Models;
using Project.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNews.Entities.Common
{
    public class Comments
    {

        public Comments()
        { }

        public Comments(string author, string comment, string email, CustomId id = null) : this(id)
        {
            this.Author = author;
            this.Comment = comment;
            this.Email = email;

        }

        public Comments(CustomId id)
        {
            this.Id = string.IsNullOrEmpty(Convert.ToString(id)) ? new CustomId().ToString() : id.ToString();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }

        [Required]
        [StringLength(155)]
        public string Comment { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        public string PostId { get; set; }

        public virtual Posts Post { get; set; }

    }
}
