using Nurse_Backend.Entities;
using Nurse_Backend.Models.Dto;
using Nurse_Backend.Models.Dto.TokenDtos;

namespace Nurse_Backend.Services.Authservice;

public interface IAuthService
{
    Task<User?> RegisterAsync(RegisterDto request);
    Task<TokenResponseDto?>  LoginAsync(UserDto request);
    
    Task<TokenResponseDto?> RefreshTokensAsync(RefreshTokenRequestDto request);
    Task LogoutAsync(Guid userId);
}