using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Models.Likes
{
    public class LikeCreateModel
    {
        [Required]
        public int PostId { get; set; }
    }
}
