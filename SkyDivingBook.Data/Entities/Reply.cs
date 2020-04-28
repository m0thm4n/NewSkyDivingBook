using SkyDivingBook.Models.Reply;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Data.Entities
{
    public class Reply
    {
        public Reply(ReplyCreateModel replyToCreate)
        {
            // ReplyComment = replyToCreate.ReplyComment;
        }

        public int ReplyId { get; set; }
        public Comment ReplyComment { get; set; }
    }
}
