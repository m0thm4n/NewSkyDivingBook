using SkyDivingBook.Data.Entities;
using SkyDivingBook.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Contracts
{
    public interface IUserService
    {
        void CreateUser(UserCreateModel userToCreate);
        List<User> GetUsers();
        void DeleteUser(int id);
        User GetUser(int id);
    }
}
