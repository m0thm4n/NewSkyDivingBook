using System;
using System.ComponentModel.DataAnnotations;

namespace SkyDivingBook.Models.Posts
{
    public class PostCreateModel
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
