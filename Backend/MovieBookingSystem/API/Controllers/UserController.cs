using API.Model;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Login(User userDetails){
            if(userDetails == null)
                return BadRequest("Invalid Request");

            var isUserExists = _userService.Login(userDetails);

            return Ok(isUserExists);
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (user == null)
                return BadRequest("Invalid Request");

            var isRegisterSuccessful = _userService.Register(user);

            if (!isRegisterSuccessful)
            {
                return BadRequest("User Already Exists!");
            }

            return Ok();
        }
    }
}
