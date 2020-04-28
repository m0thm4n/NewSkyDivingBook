using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Models.Comments
{
    public class CommentListModel
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public int Author { get; set; }
    }
}
