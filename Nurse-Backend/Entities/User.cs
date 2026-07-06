using System.ComponentModel.DataAnnotations;

namespace Nurse_Backend.Entities;

public class User
{
    public Guid Id { get; set; }
    
    [MaxLength(50)]
    public string Username { get; set; } = string.Empty;
    
    [MaxLength(255)]
    public string PasswordHash { get; set; } =  string.Empty;
    
    [MaxLength(255)]
    public string Roles { get; set; } = string.Empty;
    
    [MaxLength(100)]
    public string? RefreshToken { get; set; }
    
    public DateTime RefreshTokenExpires { get; set; }
}