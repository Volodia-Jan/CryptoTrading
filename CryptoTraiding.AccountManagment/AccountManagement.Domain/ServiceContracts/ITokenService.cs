namespace AccountManagement.Domain.ServiceContracts;

/// <summary>
/// Represents JWT token functionality
/// </summary>
public interface ITokenService
{
    /// <summary>
    /// Generates user JWT token
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="email">User email</param>
    /// <returns>JWT token</returns>
    string GenerateToken(Guid userId, string email);
}