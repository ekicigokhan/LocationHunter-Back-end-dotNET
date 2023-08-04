using LocationHunter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationHunter.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        User GetUserById(int id);
        User CreateUser(User user);
        User UpdateUser(User user);
        void DeleteUser(int id);
    }
}
