using OrderManagement.Infrastructure.Entities;

namespace OrderManagement.Infrastructure.RepositoryContracts;

/// <summary>
/// Represents wallet account DAL functionality
/// </summary>
public interface IWalletAccountsRepository
{
    /// <summary>
    /// Creates new wallet account in DB
    /// </summary>
    /// <param name="walletAccount">Wallet account information</param>
    /// <returns>Created wallet account or null if creation wasn't successful</returns>
    Task<WalletAccount?> CreateWalletAccountAsync(WalletAccount walletAccount);

    /// <summary>
    /// Updates wallet accounts
    /// </summary>
    /// <param name="walletAccount">New wallet account information</param>
    /// <returns>Updated wallet account or null if account wasn't updated</returns>
    Task<WalletAccount?> UpdateWalletAccountAsync(WalletAccount walletAccount);

    /// <summary>
    /// Deletes wallet account
    /// </summary>
    /// <param name="walletAccount">Wallet account</param>
    /// <returns>True if account was deleted</returns>
    Task<bool> DeleteWalletAccountAsync(WalletAccount walletAccount);

    /// <summary>
    /// Gets wallet account by its ID
    /// </summary>
    /// <param name="walletAccountId">Wallet account ID</param>
    /// <returns>Matched wallet account or null if account not found</returns>
    Task<WalletAccount?> GetWalletAccountByIdAsync(Guid walletAccountId);

    /// <summary>
    /// Gets wallet account by user ID
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <returns>Matched wallet account or null if account not found</returns>
    Task<WalletAccount?> GetWalletAccountByUserIdAsync(Guid userId);

    /// <summary>
    /// Check if wallet account has specific crypto wallet 
    /// </summary>
    /// <param name="walletAccountId">Wallet account ID</param>
    /// <param name="cryptoId">Cryptocurrency ID</param>
    /// <returns>True if wallet account has specific cryptocurrency wallet</returns>
    Task<bool> IsWalletAccountHasCryptoWallet(Guid walletAccountId, Guid cryptoId);

    /// <summary>
    /// Gets all wallet accounts
    /// </summary>
    /// <returns>List of wallet accounts</returns>
    Task<List<WalletAccount>> GetAllWalletAccounts();
}