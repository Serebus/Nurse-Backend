using Microsoft.AspNetCore.Mvc;
using Nurse_Backend.Entities;
using Nurse_Backend.Models.Dto;
using Nurse_Backend.Services.Interface;


namespace Nurse_Backend.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    
    public class AuthController(IAuthService authService) : ControllerBase
    {
        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDto request)
        {
            var user = await authService.RegisterAsync(request);
            if  (user is null)
                return BadRequest("username Already exists");
            
            return Ok(user);
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserDto request)
        {
            var token = await authService.LoginAsync(request);
            if (token is null)
                return BadRequest("username or password is incorrect");

            return Ok(token);
        }


        
    }
}