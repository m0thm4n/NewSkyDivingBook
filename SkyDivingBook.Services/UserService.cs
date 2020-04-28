using SkyDivingBook.API.Models;
using SkyDivingBook.Contracts;
using SkyDivingBook.Data.Entities;
using SkyDivingBook.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Services
{
    public class UserService : IUserService
    {
        public void CreateUser(UserCreateModel userToCreate)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Users.Add(new User(userToCreate));
                context.SaveChanges();
            }
        }

        public void DeleteUser(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var userToDelete = context.Users.Find(id);
                context.Users.Remove(userToDelete);
            }
        }

        public List<User> GetUsers()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Users.ToList();
            }
        }

        public User GetUser(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Users.Find(id);
            }
        }
    }
}
