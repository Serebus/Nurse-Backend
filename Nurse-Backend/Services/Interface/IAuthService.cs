using Nurse_Backend.Entities;
using Nurse_Backend.Models.Dto;

namespace Nurse_Backend.Services.Interface;

public interface IAuthService
{
    Task<User?> RegisterAsync(UserDto request);
    Task<string>  LoginAsync(UserDto request);
}