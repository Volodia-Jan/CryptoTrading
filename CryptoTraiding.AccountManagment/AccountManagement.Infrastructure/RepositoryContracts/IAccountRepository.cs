using AccountManagement.Infrastructure.Entities;

namespace AccountManagement.Infrastructure.RepositoryContracts;

/// <summary>
/// Represents user's DAL functionality
/// </summary>
public interface IAccountRepository
{
    /// <summary>
    /// Creates user in DB
    /// </summary>
    /// <param name="applicationUser">User information</param>
    /// <param name="password">User password to hash</param>
    /// <returns>Saved user information or null if saving failed</returns>
    Task<ApplicationUser?> CreateUserAccountAsync(ApplicationUser applicationUser, string password);

    /// <summary>
    /// Deletes user
    /// </summary>
    /// <param name="applicationUser">User to delete</param>
    /// <returns>True if user deleted</returns>
    Task<bool> DeleteUserAccountAsync(ApplicationUser applicationUser);

    /// <summary>
    /// Login user into account
    /// </summary>
    /// <param name="login">User login</param>
    /// <param name="password">User password</param>
    /// <returns>Logged in user info or null</returns>
    Task<ApplicationUser?> LoginAsync(string login, string password);

    /// <summary>
    /// Logout user from system
    /// </summary>
    /// <returns></returns>
    Task LogoutAsync();

    /// <summary>
    /// Checks if email already exist
    /// </summary>
    /// <param name="email">User email</param>
    /// <returns>True if email already exist</returns>
    Task<bool> IsEmailExistAsync(string email);

    /// <summary>
    /// Gets user by its ID
    /// </summary>
    /// <param name="id">User id</param>
    /// <returns>User from db or null if user doesn't exist</returns>
    Task<ApplicationUser?> GetUserById(Guid id);
}