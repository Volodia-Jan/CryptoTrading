using System.ComponentModel.DataAnnotations;

namespace AccountManagement.Domain.Requests;

/// <summary>
/// Represent login request data
/// </summary>
public class LoginRequest
{
    /// <summary>
    /// Gets or sets user login(email)
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    public string Login { get; set; }
    
    /// <summary>
    /// Gets or sets user password
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    public string Password { get; set; }
}