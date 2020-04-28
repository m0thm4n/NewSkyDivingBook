using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Models.Users
{
    class UserGetListModel
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
