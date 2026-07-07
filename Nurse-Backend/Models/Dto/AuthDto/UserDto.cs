using System.ComponentModel.DataAnnotations;

namespace Nurse_Backend.Models.Dto.AuthDto;

public class UserDto
{
    //used in login
    
    [Required, MaxLength(50)]
    public string Username { get; set; } = string.Empty;
    
    [Required, MaxLength(100)]
    public string Password { get; set; } =  string.Empty;
}