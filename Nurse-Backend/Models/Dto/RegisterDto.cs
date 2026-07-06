namespace Nurse_Backend.Models.Dto;

public class RegisterDto : UserDto
{
    public string Roles { get; set; } = string.Empty;
}
