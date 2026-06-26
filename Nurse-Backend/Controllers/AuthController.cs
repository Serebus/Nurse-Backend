using Microsoft.AspNetCore.Authorization;
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
        public async Task<ActionResult<TokenResponseDto>> Login(UserDto request)
        {
            var result = await authService.LoginAsync(request);
            if (result is null)
                return BadRequest("username or password is incorrect");

            return Ok(result);
        }


        [Authorize(Roles  = "Admin")]
        [HttpGet("Admin")]
        public IActionResult Admin()
        {
            
            
            return Ok("Welcome Admin");
        }


        
    }
}