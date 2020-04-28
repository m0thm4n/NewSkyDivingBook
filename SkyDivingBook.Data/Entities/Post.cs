using SkyDivingBook.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Data.Entities
{
    public class Post
    {
        public Post(PostCreateModel postToCreate)
        {
            PostId = postToCreate.PostId;
            Title = postToCreate.Title;
            Text = postToCreate.Text;
        }

        public int PostId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public User Author { get; set; }
    }
}
