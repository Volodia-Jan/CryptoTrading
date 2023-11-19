using OrderManagement.Domain.DTOs;
using OrderManagement.Domain.Requests;

namespace OrderManagement.Domain.ServiceContracts;

/// <summary>
/// Represents wallet business logic functionlality
/// </summary>
public interface IWalletsService
{
    /// <summary>
    /// Creates wallet
    /// </summary>
    /// <param name="createWalletRequest">Create wallet request data</param>
    /// <returns>Created wallet data</returns>
    Task<WalletDto> CreateWalletAsync(CreateWalletRequest createWalletRequest);

    /// <summary>
    /// Deletes wallet by its ID
    /// </summary>
    /// <param name="walletId">Wallet Id</param>
    /// <returns></returns>
    Task DeleteWalletAsync(Guid walletId);

    /// <summary>
    /// Gets wallet by its ID
    /// </summary>
    /// <param name="walletId">Wallet ID</param>
    /// <returns>Matched wallet</returns>
    Task<WalletDto> GetWalletByIdAsync(Guid walletId);

    /// <summary>
    /// Gets all wallets by account id
    /// </summary>
    /// <param name="walletAccountId">Wallet account ID</param>
    /// <returns>List of wallets</returns>
    Task<List<WalletDto>> GetWalletsByAccountId(Guid walletAccountId);
}