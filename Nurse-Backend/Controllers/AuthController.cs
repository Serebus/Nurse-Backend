using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nurse_Backend.Entities;
using Nurse_Backend.Models.Dto;
using Nurse_Backend.Models.Dto.TokenDtos;
using Nurse_Backend.Services.Interface;


namespace Nurse_Backend.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    
    public class AuthController(IAuthService authService) : ControllerBase
    {
        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(RegisterDto request)
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

        [HttpPost("refresh-token")]
        public async Task<ActionResult<TokenResponseDto>> RefreshToken(RefreshTokenRequestDto request)
        {
            var result = await authService.RefreshTokensAsync(request);
            if (result is null || result.AccessToken is null || result.RefreshToken is null)
                return Unauthorized("Invalid refresh token");
            return Ok(result);
        }
        
        [Authorize]
        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId is null)
                return Unauthorized();

            await authService.LogoutAsync(Guid.Parse(userId));
            return Ok("Logged out successfully");
        }
        
        
    }
}