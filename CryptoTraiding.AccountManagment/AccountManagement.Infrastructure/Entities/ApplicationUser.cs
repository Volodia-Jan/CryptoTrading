using Microsoft.AspNetCore.Identity;

namespace AccountManagement.Infrastructure.Entities;

/// <summary>
/// Represents application user
/// </summary>
public class ApplicationUser : IdentityUser<Guid>
{
    /// <summary>
    /// Gets or sets user full name
    /// </summary>
    public string FullName { get; set; }
    
    /// <summary>
    /// Gets or sets user date of birth
    /// </summary>
    public DateTime DateOfBirth { get; set; }
    
    /// <summary>
    /// Gets or sets user creating date & time 
    /// </summary>
    public DateTime CreatedAt { get; set; }
}