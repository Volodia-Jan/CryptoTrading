using Microsoft.AspNetCore.Mvc;
using OrderManagement.Domain.DTOs;
using OrderManagement.Domain.ServiceContracts;

namespace CryptoTraiding.OrderManagement.Controllers;

/// <summary>
/// Represents cryptocurrency API functionality
/// </summary>
[ApiController]
[Route("crypto")]
public class CryptocurrenciesController : ControllerBase
{
    private readonly ICryptocurrenciesService _cryptoService;

    public CryptocurrenciesController(ICryptocurrenciesService cryptoService)
    {
        _cryptoService = cryptoService;
    }

    /// <summary>
    /// Gets all cryptocurrencies
    /// </summary>
    /// <returns>List of cryptocurrencies</returns>
    [HttpGet]
    public async Task<ActionResult<List<CryptocurrencyDto>>> GetAllCryptos() =>
        await _cryptoService.GetAllCryptocurrenciesAsync();

    /// <summary>
    /// Gets specific cryptocurrency
    /// </summary>
    /// <param name="cryptoId">Cryptocurrency ID</param>
    /// <returns>Cryptocurrency</returns>
    [HttpGet("{cryptoId}")]
    public async Task<ActionResult<CryptocurrencyDto>> GetCryptoById(Guid cryptoId) =>
        await _cryptoService.GetCryptoCurrencyAsync(cryptoId);
}