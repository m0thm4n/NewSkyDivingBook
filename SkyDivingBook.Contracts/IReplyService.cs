using SkyDivingBook.Data.Entities;
using SkyDivingBook.Models.Reply;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Contracts
{
    public interface IReplyService
    {
        void CreateReply(ReplyCreateModel userToCreate);
        List<Reply> GetReplies();
        void DeleteReply(int id);
        Reply GetReply(int id);
    }
}
