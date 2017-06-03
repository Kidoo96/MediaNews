using MediaNews.Entities.Common;
using Project.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNews.Entities.Models
{
    public class Posts
    {
        public Posts()
        {

        }

        public Posts(string categoryId, string authorId, string title, string desc, string content, 
            string imgUrl, DateTime datePublish, DateTime? dateModified, CustomId id = null) 
            : this(id)
        {
            this.CategoryId = categoryId;
            this.AuthorId = authorId;
            this.Title = title;
            this.Description = desc;
            this.Content = content;
            this.ImgUrl = imgUrl;
            this.DatePublished = datePublish;
            this.DateModified = dateModified;
        }

        public Posts(CustomId id)
        {
            this.Id = string.IsNullOrEmpty(Convert.ToString(id)) ? new CustomId().ToString() : id.ToString();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Заглавие")]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Кратко описание")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Описание")]
        public string Content { get; set; }

        public string ImgUrl { get; set; }

        [Required]
        public string AuthorId { get; set; }

        public virtual User Author { get; set; }

        [Required]
        public string CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public DateTime DatePublished { get; set; }

        public DateTime? DateModified { get; set; }

        public virtual ICollection<Comments> Comments { get; set;}

    }
}
