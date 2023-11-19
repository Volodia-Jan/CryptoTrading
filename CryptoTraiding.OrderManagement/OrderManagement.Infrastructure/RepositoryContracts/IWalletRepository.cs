using OrderManagement.Infrastructure.Entities;

namespace OrderManagement.Infrastructure.RepositoryContracts;

/// <summary>
/// Represents wallet DAL functionality
/// </summary>
public interface IWalletRepository
{
    /// <summary>
    /// Creates new wallet
    /// </summary>
    /// <param name="wallet">wallet information</param>
    /// <returns></returns>
    Task<Wallet?> CreateWalletAsync(Wallet wallet);

    /// <summary>
    /// Updates existed wallet
    /// </summary>
    /// <param name="wallet">wallet information to update</param>
    /// <returns></returns>
    Task<Wallet?> UpdateWalletAsync(Wallet wallet);

    /// <summary>
    /// Deletes existed wallet 
    /// </summary>
    /// <param name="wallet">Wallet information to delete</param>
    /// <returns></returns>
    Task<bool> DeleteWalletAsync(Wallet wallet);

    /// <summary>
    /// Gets wallet by its ID
    /// </summary>
    /// <param name="walletId">Wallet ID</param>
    /// <returns>Wallet information or null if wallet not fount </returns>
    Task<Wallet?> GetWalletById(Guid walletId);

    /// <summary>
    /// Gets wallet by account ID
    /// </summary>
    /// <param name="walletAccountId">Account ID</param>
    /// <returns>Wallets list</returns>
    Task<List<Wallet>> GetWalletsByAccountId(Guid walletAccountId);
}