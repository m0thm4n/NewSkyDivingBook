using SkyDivingBook.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Models.Replies
{
    public class ReplyCreateModel
    {
        public int ReplyId { get; set; }
        public Comment ReplyComment { get; set; }
    }
}
