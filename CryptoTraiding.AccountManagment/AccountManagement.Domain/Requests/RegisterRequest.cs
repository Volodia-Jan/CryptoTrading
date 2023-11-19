using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccountManagement.Domain.Requests;

/// <summary>
/// Represent register request
/// </summary>
public class RegisterRequest
{
    /// <summary>
    /// Gets or sets user full name 
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    [DisplayName("Full name")]
    public string FullName { get; set; }
    
    /// <summary>
    /// Gets or sets user email
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    [EmailAddress(ErrorMessage = "{0} has invalid format of email")]
    public string Email { get; set; }
    
    /// <summary>
    /// Gets or sets date of birth
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    [DisplayName("Date of birth")]
    public DateTime DateOfBirth { get; set; }
    
    /// <summary>
    /// Gets or sets user password
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    public string Password { get; set; }
    
    /// <summary>
    /// Gets or sets user password for confirmation
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    [Compare("Password", ErrorMessage = "{0} must be equal to {1}")]
    [DisplayName("Confirm password")]
    public string ConfirmPassword { get; set; }
}