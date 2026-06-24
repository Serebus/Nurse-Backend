using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Nurse_Backend.Entities;
using Nurse_Backend.Models.Dto;


namespace Nurse_Backend.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    
    public class AuthController : ControllerBase
    {
        public static User user = new();
        
        [HttpPost("register")]
        public ActionResult<User> Register(UserDto request)
        {
            var hashedPassword = new PasswordHasher<User>()
                .HashPassword(user, request.Password);
            
            user.Username = request.Username;
            user.PasswordHash =  hashedPassword;
            
            return Ok(user);
        }

        [HttpPost("login")]
        public ActionResult<string> Login(UserDto request)
        {
            if (user.Username != request.Username)
            {
                return BadRequest("User name does not Exist");
            }

            if (new PasswordHasher<User>().VerifyHashedPassword(user, user.PasswordHash, request.Password)
                == PasswordVerificationResult.Failed)
            {
                return BadRequest("Password is incorrect");
            }

            string token = "success";

                return Ok(token);
        }
        
    }
}