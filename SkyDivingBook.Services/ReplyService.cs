using SkyDivingBook.API.Models;
using SkyDivingBook.Data.Entities;
using SkyDivingBook.Models.Reply;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Services
{
    public class ReplyService
    {
        public void CreateReply(ReplyCreateModel replyToCreate)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Replies.Add(new Reply(replyToCreate));
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

        public List<Reply> GetReplies()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Replies.ToList();
            }
        }

        public Reply GetReply(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Replies.Find(id);
            }
        }
    }
}
