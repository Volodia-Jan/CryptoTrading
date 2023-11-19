using OrderManagement.Infrastructure.Entities;
using OrderManagement.Infrastructure.Entities.Enums;

namespace OrderManagement.Infrastructure.RepositoryContracts;

/// <summary>
/// Represents trades DAL functionality
/// </summary>
public interface ITradesRepository
{
    /// <summary>
    /// Gets all accounts trades
    /// </summary>
    /// <param name="walletAccountId">Wallet account ID</param>
    /// <returns>List of wallet account trades</returns>
    Task<List<Trade>> GetAllAccountTradesAsync(Guid walletAccountId);

    /// <summary>
    /// Gets all wallets trades by wallet ID
    /// </summary>
    /// <param name="walletId">Wallet ID</param>
    /// <returns>List of wallets trades</returns>
    Task<List<Trade>> GetAllWalletTradesAsync(Guid walletId);

    /// <summary>
    /// Gets trade by its ID
    /// </summary>
    /// <param name="tradeId">Trade ID</param>
    /// <returns>Trade information or null if trade not found</returns>
    Task<Trade?> GetTradeAsync(Guid tradeId);

    /// <summary>
    /// Gets all trades
    /// </summary>
    /// <returns>List of trades</returns>
    Task<List<Trade>> GetAllTradesAsync();
    
    /// <summary>
    /// Gets trades by type
    /// </summary>
    /// <param name="tradeType">Trade type</param>
    /// <returns>List of trades that matched to type</returns>
    Task<List<Trade>> GetAllTradesByTypeAsync(TradeType tradeType);

    /// <summary>
    /// Gets all trades by status
    /// </summary>
    /// <param name="tradeStatus">Trade status</param>
    /// <returns>List of trades that matched to status</returns>
    Task<List<Trade>> GetAllTradesByStatusAsync(TradeStatus tradeStatus);

    /// <summary>
    /// Creates trade
    /// </summary>
    /// <param name="trade">Trade information</param>
    /// <returns></returns>
    Task<Trade?> CreateTradeAsync(Trade trade);

    /// <summary>
    /// Updates trade information
    /// </summary>
    /// <param name="trade">Trade information</param>
    /// <returns>Updated trade or null if updating wasn't successful</returns>
    Task<Trade?> UpdateTradeAsync(Trade trade);

    /// <summary>
    /// Deletes trade
    /// </summary>
    /// <param name="trade">trade to delete</param>
    /// <returns>True if trade was deleted</returns>
    Task<bool> DeleteTradeAsync(Trade trade);
}