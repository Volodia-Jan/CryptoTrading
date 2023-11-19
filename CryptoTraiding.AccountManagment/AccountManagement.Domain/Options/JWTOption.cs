namespace AccountManagement.Domain.Options;

/// <summary>
/// Represents JWT configuration
/// </summary>
public class JWTOption
{
    /// <summary>
    /// Configuration section alias
    /// </summary>
    public const string JWTOptionSecion = "JWT";

    /// <summary>
    /// Gets or sets Token creator
    /// </summary>
    public string Issuer { get; set; }
    
    /// <summary>
    /// Gets or sets Token clients
    /// </summary>
    public string Audience { get; set; }
    
    /// <summary>
    /// Gets or sets Secret key
    /// </summary>
    public string Key { get; set; }  
    
    /// <summary>
    /// Gets or sets expiration time in minutes
    /// </summary>
    public int ExpirationTimeInMinutes { get; set; }
}