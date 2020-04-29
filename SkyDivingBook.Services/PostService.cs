using SkyDivingBook.API.Models;
using SkyDivingBook.Contracts;
using SkyDivingBook.Data.Entities;
using SkyDivingBook.Models.Posts;
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
            var entity = new Post()
            {
                PostId = postToCreate.PostId,
                Title = postToCreate.Title,
                Text = postToCreate.Text,
                UserId = postToCreate.UserId
            };

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Posts.Add(entity);
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
