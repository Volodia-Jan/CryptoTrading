namespace OrderManagement.Domain.ServiceContracts;

/// <summary>
/// Represents user business logic functionality
/// </summary>
public interface IUserService
{
    /// <summary>
    /// Gets user id from claims
    /// </summary>
    /// <returns>User id</returns>
    /// <exception cref="ArgumentException">In case of id claim not found or it was in wrong format(not in GUID)</exception>
    Guid GetAuthorizedUserId();
}