using SkyDivingBook.API.Models;
using SkyDivingBook.Contracts;
using SkyDivingBook.Data.Entities;
using SkyDivingBook.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Services
{
    public class PostService : IPostService
    {
        public void CreatePost(PostCreateModel postToCreate)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Posts.Add(new Post(postToCreate));
                context.SaveChanges();
            }
        }

        public void DeletePost(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var postToDelete = context.Posts.Find(id);
                context.Posts.Remove(postToDelete);
                context.SaveChanges();
            }
        }

        public Post GetPost(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Posts.Find(id);
            }
        }

        public IEnumerable<Post> GetPosts()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Posts.ToList();
            }
        }
    }
}
