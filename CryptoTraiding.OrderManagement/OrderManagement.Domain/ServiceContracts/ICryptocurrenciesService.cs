using OrderManagement.Domain.DTOs;

namespace OrderManagement.Domain.ServiceContracts;

/// <summary>
/// Represents cryptocurrency business logic functionality
/// </summary>
public interface ICryptocurrenciesService
{
    /// <summary>
    /// Get all available cryptocurrencies
    /// </summary>
    /// <returns>List of all available</returns>
    Task<List<CryptocurrencyDto>> GetAllCryptocurrenciesAsync();

    /// <summary>
    /// Gets specific cryptocurrency by its ID
    /// </summary>
    /// <param name="cryptoId">Cryptocurrency ID</param>
    /// <returns></returns>
    Task<CryptocurrencyDto> GetCryptoCurrencyAsync(Guid cryptoId);
}