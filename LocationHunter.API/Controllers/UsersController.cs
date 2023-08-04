using LocationHunter.Business.Abstract;
using LocationHunter.Business.Concrete;
using LocationHunter.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LocationHunter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        public UsersController(IUserService userService)
        {
            this._userService = userService;
        }
        [HttpGet("getAllUsers")]
        public List<User> GetUsers()
        {
            return _userService.GetAllUsers();
        }
        [HttpGet("{id}")]
        public User GetUserById(int id)
        {
            return _userService.GetUserById(id);
        }

        [HttpPost("addUser")]
        public User AddUser(User user)
        {
            Console.WriteLine("çalıştım");
            return _userService.CreateUser(user);
        }

        [HttpPut("updateUser")]
        public IActionResult updateUser(User user)
        {
            var updatedUser = _userService.UpdateUser(user);
            return Ok(updatedUser);
        }
        
        [HttpDelete("{id}")]
        public IActionResult deleteUser(int id)
        {
            _userService.DeleteUser(id);
            return Ok("Başarıyla silndi.");
        }
        
    }
}
