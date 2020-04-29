using SkyDivingBook.Data.Entities;
using SkyDivingBook.Models.Replies;
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
        IEnumerable<ReplyGetAllModel> GetReplies();
        void DeleteReply(int id);
        ReplyGetModel GetReply(int id);
    }
}
