using SkyDivingBook.Models.Comment;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Data.Entities
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string Text { get; set; }

        [Required]
        [ForeignKey("User")]
        public int Author { get; set; }

        [Required]
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public virtual Post CommentPost { get; set; }

        public Comment() { }

        public Comment(CommentCreateModel commentToCreate)
        {
            Text = commentToCreate.Text;
        }
    }
}
