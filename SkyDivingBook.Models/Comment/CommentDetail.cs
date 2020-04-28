using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Models.Comment
{
    public class CommentDetail
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public int Author { get; set; }
        public int PostId { get; set; }
        public virtual Post CommentPost { get; set; }
    }
}