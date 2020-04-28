using SkyDivingBook.API.Models;
using SkyDivingBook.Contracts;
using SkyDivingBook.Data;
using SkyDivingBook.Data.Entities;
using SkyDivingBook.Models.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Services
{
    public class CommentService : ICommentService
    {
        public void CreateComment(CommentCreateModel commentToCreate)
        {
            var entity = new Comment()
            {
                Text = commentToCreate.Text
            };

            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                ctx.Comments.Add(entity);
                ctx.SaveChanges();
            }
        }

        public IEnumerable<CommentListModel> GetAllComments()
        {
            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                var entities =
                    ctx
                    .Comments
                    .Select(
                        x => new CommentListModel
                        {
                            CommentId = x.CommentId,
                            Text = x.Text,
                            Author = x.Author
                        });

                return entities.ToArray();
            }
        }

        public CommentDetail GetCommentById(int commentId)
        {
            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                var entity = ctx.Comments.Single(x => x.PostId == commentId);
                return
                    new CommentDetail
                    {
                        CommentId = entity.CommentId,
                        Text = entity.Text,
                        Author = entity.Author,
                        PostId = entity.PostId,
                        // CommentPost = entity.CommentPost
                    };
            }
        }

        public void UpdateComment(CommentEditModel comment)
        {
            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                var entity = ctx.Comments.Single(x => x.CommentId == comment.CommentId);
                entity.Text = comment.Text;
                ctx.SaveChanges();
            }
        }

        public void DeleteComment(int commentId)
        {
            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                var entity = ctx.Comments.Single(x => x.PostId == commentId);
                ctx.Comments.Remove(entity);
                ctx.SaveChanges();
            }
        }
    }
}
