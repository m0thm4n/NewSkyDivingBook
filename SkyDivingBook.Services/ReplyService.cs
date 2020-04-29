using SkyDivingBook.API.Models;
using SkyDivingBook.Contracts;
using SkyDivingBook.Data.Entities;
using SkyDivingBook.Models.Posts;
using SkyDivingBook.Models.Replies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Services
{
    public class ReplyService : IReplyService
    {
        public void CreateReply(ReplyCreateModel replyToCreate)
        {
            var entity = new Reply()
            {
                ReplyId = replyToCreate.ReplyId,
                ReplyComment = replyToCreate.ReplyComment,
                CommentId = replyToCreate.CommentId
            };

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Replies.Add(entity);
                context.SaveChanges();
            }
        }

        public void DeleteReply(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var replyToDelete = context.Replies.Find(id);
                context.Replies.Remove(replyToDelete);
            }
        }

        public IEnumerable<ReplyGetAllModel> GetReplies()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var entities =
                   context
                   .Replies
                   .Select(
                       x => new ReplyGetAllModel
                       {
                           ReplyId = x.ReplyId,
                           ReplyComment = x.ReplyComment
                           // Author = x.Author
                       });

                return entities.ToArray();
            }
        }

        public ReplyGetModel GetReply(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var entity =
                   context
                   .Replies
                   .Select(
                       x => new ReplyGetModel
                       {
                           ReplyId = x.ReplyId,
                           ReplyComment = x.ReplyComment
                           // Author = x.Author
                       });

                return (ReplyGetModel)entity;
            }
        }
    }
}
