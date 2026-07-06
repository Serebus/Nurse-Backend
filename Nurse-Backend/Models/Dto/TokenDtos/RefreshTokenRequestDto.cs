namespace Nurse_Backend.Models.Dto.TokenDtos;

public class RefreshTokenRequestDto
{
    public Guid UserId { get; set; }
    
    public required string RefreshToken { get; set; }
    
    
}