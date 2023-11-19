using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Domain.DTOs;
using OrderManagement.Domain.Requests;
using OrderManagement.Domain.ServiceContracts;

namespace CryptoTraiding.OrderManagement.Controllers;

/// <summary>
/// Represents wallet account API functionality
/// </summary>
[ApiController]
[Route("accounts")]
[Authorize]
public class WalletAccountsController : ControllerBase
{
    private readonly IWalletAccountsService _accountsService;

    public WalletAccountsController(IWalletAccountsService accountsService)
    {
        _accountsService = accountsService;
    }

    /// <summary>
    /// Create wallet account for authorized user
    /// </summary>
    /// <returns>Wallet account</returns>
    [HttpPost]
    public async Task<ActionResult<WalletAccountDto>> CreateUserWalletAccount() => 
        await _accountsService.CreateWalletAccountAsync();

    /// <summary>
    /// Deposits to wallet account of authorized user
    /// </summary>
    /// <param name="depositRequest">Deposit request data</param>
    /// <returns>Wallet account</returns>
    [HttpPost("deposit")]
    public async Task<ActionResult<WalletAccountDto>> Deposit(DepositRequest depositRequest) =>
        await _accountsService.DepositAsync(depositRequest);

    /// <summary>
    /// Deletes wallet account for authorized user
    /// </summary>
    /// <returns>Successful message</returns>
    [HttpDelete]
    public async Task<IActionResult> DeleteAccount()
    {
        await _accountsService.DeleteWalletAccountAsync();

        return Ok("Wallet account was deleted successfully");
    }
    
    /// <summary>
    /// Get current user wallet account
    /// </summary>
    /// <returns>Wallet account</returns>
    [HttpGet]
    public async Task<ActionResult<WalletAccountDto>> GetWalletAccount() =>
        await _accountsService.GetUserWalletAccountAsync();

    /// <summary>
    /// Gets all wallet accounts(for presentation)
    /// </summary>
    /// <returns>List of all wallet accounts</returns>
    [HttpGet("list")]
    public async Task<ActionResult<List<WalletAccountDto>>> GetAllWalletsAccount() =>
        await _accountsService.GetAllWalletAccountsAsync();
}