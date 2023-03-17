using API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public static List<User> UserList = new List<User>()
        {
            new User(){
                Name = "Admin",
                Email = "admin@admin.com",
                Password = "admin123" // can be hashed later on. 
            },
            new User(){
            Name = "User",
                Email = "user@user.com",
                Password = "user123" // can be hashed later on. 
            }
        };
        public UserController()
        {

        }
        [HttpPost]
        [Route("login")]
        public IActionResult Login(User userDetails){
            if(userDetails == null)
                return BadRequest("Invalid Request");

            var isUserExists = UserList.Exists(x => x.Email == userDetails.Email && x.Password == userDetails.Password);

            return Ok(isUserExists);
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (user == null)
                return BadRequest("Invalid Request");

            var isUserExists = UserList.Exists(x => x.Email == user.Email);

            if (isUserExists)
            {
                return BadRequest("User Already Exists!");
            }

            UserList.Add(user);

            return Ok();
        }
    }
}
