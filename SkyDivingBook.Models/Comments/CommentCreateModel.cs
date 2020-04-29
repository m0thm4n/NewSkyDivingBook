using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Models.Comments
{
    public class CommentCreateModel
    {
        public string Text { get; set; }
        public int PostId { get; set; }
        public Guid UserId { get; set; }
        public int Author { get; set; }
    }
}
    