using SkyDivingBook.Data.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace SkyDivingBook.Models.Posts
{
    public class PostCreateModel
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Guid UserId { get; set; }
    }
}
