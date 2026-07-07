using System.ComponentModel.DataAnnotations;

namespace Nurse_Backend.Models.Dto.AuthDto;

public class RegisterDto : UserDto
{
    [MaxLength(255)]
    public string Roles { get; set; } = string.Empty;
}
