using SkyDivingBook.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Data.Entities
{
    public class User
    {
        public User(UserCreateModel userToCreate)
        {
            UserId = userToCreate.UserId;
            Name = userToCreate.Name;
            Email = userToCreate.Email;
        }

        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
