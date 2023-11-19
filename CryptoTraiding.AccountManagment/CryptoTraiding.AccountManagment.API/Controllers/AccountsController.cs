using AccountManagement.Domain.DTOs;
using AccountManagement.Domain.Requests;
using AccountManagement.Domain.ServiceContracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CryptoTraiding.AccountManagment.Controllers;

/// <summary>
/// API account controller
/// </summary>
[ApiController]
[Route("[controller]")]
public class AccountsController : ControllerBase
{
    private readonly IAccountService _accountService;

    public AccountsController(IAccountService accountService)
    {
        _accountService = accountService;
    }
    
    [HttpPost("register")]
    public async Task<ApplicationUserDto> RegisterUser(RegisterRequest registerRequest) =>
        await _accountService.RegisterUserAsync(registerRequest);

    [HttpPost("login")]
    public async Task<ApplicationUserDto> LoginUser(LoginRequest loginRequest) =>
        await _accountService.LoginUserAsync(loginRequest);

    [Authorize]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(Guid id)
    {
        await _accountService.DeleteUserAsync(id);

        return Ok();
    }

    [Authorize]
    [HttpPost("logout")]
    public async Task<IActionResult> Logout()
    {
        await _accountService.LogOutAsync();

        return Ok();
    }
}