namespace AccountManagement.Domain.DTOs;

/// <summary>
/// Represents user DTO
/// </summary>
public class ApplicationUserDto
{
    /// <summary>
    /// Gets or sets application user ID
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets application user full name
    /// </summary>
    public string FullName { get; set; }
    
    /// <summary>
    /// Gets or sets application user email
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets application user date of birth
    /// </summary>
    public DateTime DateOfBirth { get; set; }
    
    /// <summary>
    /// Gets or sets application user creation date
    /// </summary>
    public DateTime CreatedAt { get; set; }
    
    /// <summary>
    /// Gets or sets application user JWT token
    /// </summary>
    public string Token { get; set; }
}