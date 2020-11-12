using Flipper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Data
{
    public interface IUsersRepo
    {
        bool SaveChanges();
        IEnumerable<Users> GetAllUsers();
        Users GetUserById(int id);
        void CreateUser(Users user);
        void UpdateUser(Users user);
        void DeleteUser(Users user);
    }
}
