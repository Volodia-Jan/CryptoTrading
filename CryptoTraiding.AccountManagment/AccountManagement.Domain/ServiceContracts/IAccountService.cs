using AccountManagement.Domain.DTOs;
using AccountManagement.Domain.Requests;

namespace AccountManagement.Domain.ServiceContracts;

/// <summary>
/// Represents accounts business logic
/// </summary>
public interface IAccountService
{
    /// <summary>
    /// Register user in system
    /// </summary>
    /// <param name="registerDto">User data</param>
    /// <returns>New user</returns>
    /// <exception cref="ArgumentException">In case of failed registration</exception>
    Task<ApplicationUserDto> RegisterUserAsync(RegisterRequest registerDto);

    /// <summary>
    /// Login user in system
    /// </summary>
    /// <param name="loginRequest">Login data: login & password</param>
    /// <returns>Loggined user</returns>
    /// <exception cref="ArgumentException">In case of failed login operation</exception>
    Task<ApplicationUserDto> LoginUserAsync(LoginRequest loginRequest);

    /// <summary>
    /// Deletes user from system
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <returns></returns>
    Task DeleteUserAsync(Guid userId);

    /// <summary>
    /// Logs out user from system
    /// </summary>
    /// <returns></returns>
    Task LogOutAsync();
}