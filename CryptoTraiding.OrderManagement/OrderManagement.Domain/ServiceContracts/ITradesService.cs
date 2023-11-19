using OrderManagement.Domain.DTOs;
using OrderManagement.Domain.Requests;
using OrderManagement.Infrastructure.Entities.Enums;

namespace OrderManagement.Domain.ServiceContracts;

/// <summary>
/// Represents trades business logic functionality
/// </summary>
public interface ITradesService
{
    /// <summary>
    /// Creates trade
    /// </summary>
    /// <param name="createTradeRequest">Create trade request data</param>
    /// <returns>Created trade</returns>
    Task<TradeDto> CreateTradeAsync(CreateTradeRequest createTradeRequest);

    /// <summary>
    /// Deletes trade by its ID
    /// </summary>
    /// <param name="tradeId">Trade ID</param>
    /// <returns></returns>
    Task DeleteTradeAsync(Guid tradeId);

    /// <summary>
    /// Gets all trade by its status
    /// </summary>
    /// <param name="tradeStatus">Trade status</param>
    /// <returns>List of matched trades</returns>
    Task<List<TradeDto>> GetAllTradesByStatusAsync(TradeStatus tradeStatus);
    
    /// <summary>
    /// Gets all trades by its type
    /// </summary>
    /// <param name="tradeType">Trade type</param>
    /// <returns>List of matched trades</returns>
    Task<List<TradeDto>> GetAllTradesByTypeAsync(TradeType tradeType);
    
    /// <summary>
    /// Gets all trades
    /// </summary>
    /// <returns>List of trades</returns>
    Task<List<TradeDto>> GetAllTradesAsync();

    /// <summary>
    /// Gets trade by its ID
    /// </summary>
    /// <param name="tradeid">Trade ID</param>
    /// <returns></returns>
    Task<TradeDto> GetTradeAsync(Guid tradeid);

    /// <summary>
    /// Gets all wallet trades
    /// </summary>
    /// <param name="walletId">Wallet ID</param>
    /// <returns>List of wallet trades</returns>
    Task<List<TradeDto>> GetAllWalletTradesAsync(Guid walletId);
    
    /// <summary>
    /// Gets all wallet account trades
    /// </summary>
    /// <param name="walletAccountId">Wallet account ID</param>
    /// <returns>List of wallet account trades</returns>
    Task<List<TradeDto>> GetAllWalletAccountTradesAsync(Guid walletAccountId);

    /// <summary>
    /// Closes trade
    /// </summary>
    /// <param name="tradeId">Trade ID</param>
    /// <returns>Closed trade</returns>
    Task<TradeDto> CloseTradeAsync(Guid tradeId);
}