using LocationHunter.Business.Abstract;
using LocationHunter.DataAccess.Abstract;
using LocationHunter.DataAccess.Concrete;
using LocationHunter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationHunter.Business.Concrete
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public User CreateUser(User user)
        {
            return _userRepository.CreateUser(user);
        }

        public User UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }

        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }
    }
}
