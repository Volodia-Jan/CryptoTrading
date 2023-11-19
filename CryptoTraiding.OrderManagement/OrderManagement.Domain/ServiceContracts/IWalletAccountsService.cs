using OrderManagement.Domain.DTOs;
using OrderManagement.Domain.Requests;

namespace OrderManagement.Domain.ServiceContracts;

/// <summary>
/// Represents wallet accounts business logic
/// </summary>
public interface IWalletAccountsService
{
    /// <summary>
    /// Creates wallet account for authorized user
    /// </summary>
    /// <returns></returns>
    Task<WalletAccountDto> CreateWalletAccountAsync();

    /// <summary>
    /// Make deposit on specific wallet account
    /// </summary>
    /// <param name="depositRequest"></param>
    /// <returns></returns>
    Task<WalletAccountDto> DepositAsync(DepositRequest depositRequest);

    /// <summary>
    /// Deletes authorized user's wallet account
    /// </summary>
    /// <returns></returns>
    Task DeleteWalletAccountAsync();

    /// <summary>
    /// Get authorized user wallet account
    /// </summary>
    /// <returns></returns>
    Task<WalletAccountDto> GetUserWalletAccountAsync();

    /// <summary>
    /// Get all wallet accounts
    /// </summary>
    /// <returns></returns>
    Task<List<WalletAccountDto>> GetAllWalletAccountsAsync();
}