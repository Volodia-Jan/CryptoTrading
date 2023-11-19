using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Domain.DTOs;
using OrderManagement.Domain.Requests;
using OrderManagement.Domain.ServiceContracts;
using OrderManagement.Infrastructure.Entities.Enums;

namespace CryptoTraiding.OrderManagement.Controllers;

/// <summary>
/// Represents trades API functionality
/// </summary>
[ApiController]
[Route("[controller]")]
[Authorize]
public class TradesController : ControllerBase
{
    private readonly ITradesService _tradesService;

    public TradesController(ITradesService tradesService)
    {
        _tradesService = tradesService;
    }

    /// <summary>
    /// Creates trade
    /// </summary>
    /// <param name="createTradeRequest">Create trade request data</param>
    /// <returns>Created trade data</returns>
    [HttpPost]
    public async Task<ActionResult<TradeDto>> CreateTrade(CreateTradeRequest createTradeRequest) =>
        await _tradesService.CreateTradeAsync(createTradeRequest);

    /// <summary>
    /// Deletes trade by its ID
    /// </summary>
    /// <param name="tradeId">TradeID</param>
    /// <returns>Successful message</returns>
    [HttpDelete("{tradeId}")]
    public async Task<IActionResult> DeleteTrade(Guid tradeId)
    {
        await _tradesService.DeleteTradeAsync(tradeId);

        return Ok("Trade was deleted successfully");
    }

    /// <summary>
    /// Gets trades by provided status
    /// </summary>
    /// <param name="tradeStatus">Trade status</param>
    /// <returns>List of matched trades</returns>
    [HttpGet("status")]
    public async Task<ActionResult<List<TradeDto>>> GetTradesByStatus([FromQuery] TradeStatus tradeStatus) =>
        await _tradesService.GetAllTradesByStatusAsync(tradeStatus);

    /// <summary>
    /// Gets trades by provided type
    /// </summary>
    /// <param name="tradeType">Trade type</param>
    /// <returns>List of matched trades</returns>
    [HttpGet("type")]
    public async Task<ActionResult<List<TradeDto>>> GetTradesByType([FromQuery] TradeType tradeType) =>
        await _tradesService.GetAllTradesByTypeAsync(tradeType);

    /// <summary>
    /// Gets all trades
    /// </summary>
    /// <returns>List of all trades</returns>
    [HttpGet]
    public async Task<ActionResult<List<TradeDto>>> GetAllTrades() =>
        await _tradesService.GetAllTradesAsync();

    /// <summary>
    /// Gets trade by its ID
    /// </summary>
    /// <param name="id">Trade ID</param>
    /// <returns>Matched trade</returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<TradeDto>> GetTradeById(Guid id) =>
        await _tradesService.GetTradeAsync(id);

    /// <summary>
    /// Get all trades for provided wallet account 
    /// </summary>
    /// <param name="walletAccountId">Wallet account ID</param>
    /// <returns>List of matched trade</returns>
    [HttpGet("account/{walletAccountId}")]
    public async Task<ActionResult<List<TradeDto>>> GetAllWalletAccountTrades(Guid walletAccountId) =>
        await _tradesService.GetAllWalletAccountTradesAsync(walletAccountId);

    /// <summary>
    /// Gets all trades for provided wallet
    /// </summary>
    /// <param name="walletId">Wallet ID</param>
    /// <returns>List of matched trade</returns>
    [HttpGet("wallet/{walletId}")]
    public async Task<ActionResult<List<TradeDto>>> GetAllWalletTrades(Guid walletId) =>
        await _tradesService.GetAllWalletTradesAsync(walletId);

    /// <summary>
    /// Closes trade
    /// </summary>
    /// <param name="id">Trade ID</param>
    /// <returns>Closed trade data</returns>
    [HttpPost("{id}/close")]
    public async Task<ActionResult<TradeDto>> CloseTrade(Guid id) =>
        await _tradesService.CloseTradeAsync(id);
}