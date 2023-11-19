using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Domain.DTOs;
using OrderManagement.Domain.Requests;
using OrderManagement.Domain.ServiceContracts;

namespace CryptoTrading.OrderManagement.Controllers;

/// <summary>
/// Represents wallets API functionality
/// </summary>
[ApiController]
[Route("[controller]")]
[Authorize]
public class WalletsController : ControllerBase
{
    private readonly IWalletsService _walletsService;

    public WalletsController(IWalletsService walletsService)
    {
        _walletsService = walletsService;
    }

    /// <summary>
    /// Creates wallet
    /// </summary>
    /// <param name="createWalletRequest">Create wallet request data</param>
    /// <returns>Created wallet</returns>
    [HttpPost]
    public async Task<ActionResult<WalletDto>> CreateWallet(CreateWalletRequest createWalletRequest) =>
        await _walletsService.CreateWalletAsync(createWalletRequest);

    /// <summary>
    /// Gets wallet by ID
    /// </summary>
    /// <param name="walletId">Wallet ID</param>
    /// <returns>Matched wallet</returns>
    [HttpGet("{walletId}")]
    public async Task<ActionResult<WalletDto>> GetWallet(Guid walletId) =>
        await _walletsService.GetWalletByIdAsync(walletId);

    /// <summary>
    /// Deletes wallet by its ID
    /// </summary>
    /// <param name="walletId">Wallet ID</param>
    /// <returns>Successful message</returns>
    [HttpDelete("{walletId}")]
    public async Task<IActionResult> DeleteWallet(Guid walletId)
    {
        await _walletsService.DeleteWalletAsync(walletId);

        return Ok("Wallet was deleted successfully");
    }

    /// <summary>
    /// Get all wallets for provided wallet account
    /// </summary>
    /// <param name="walletAccountId">Wallet account ID</param>
    /// <returns>List of matched wallets</returns>
    [HttpGet]
    public async Task<ActionResult<List<WalletDto>>> GetWalletsByAccountId([FromQuery] Guid walletAccountId) =>
        await _walletsService.GetWalletsByAccountId(walletAccountId);
}