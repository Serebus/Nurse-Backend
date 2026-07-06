using System.ComponentModel.DataAnnotations;

namespace Nurse_Backend.Models.Dto.TokenDtos;

public class RefreshTokenRequestDto
{
    public Guid UserId { get; set; }
    
    [Required, MaxLength(100)]
    public required string RefreshToken { get; set; }
}