using Nurse_Backend.Entities;
using Nurse_Backend.Models.Dto;

namespace Nurse_Backend.Services.Interface;

public interface IAuthService
{
    Task<User?> RegisterAsync(UserDto request);
    Task<TokenResponseDto?>  LoginAsync(UserDto request);
    
    Task<TokenResponseDto?> RefreshTokensAsync(RefreshTokenRequestDto request);
    Task LogoutAsync(Guid userId);
}