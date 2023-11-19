using OrderManagement.Infrastructure.Entities;

namespace OrderManagement.Infrastructure.RepositoryContracts;

/// <summary>
/// Represents crypto currency DAL functionality
/// </summary>
public interface ICryptocurrencyRepository
{
    /// <summary>
    /// Gets all crypto currencies
    /// </summary>
    /// <returns>List of available crypto currencies</returns>
    Task<List<Cryptocurrency>> GetAllCryptocurrenciesAsync();

    /// <summary>
    /// Get crypto currency by its ID
    /// </summary>
    /// <param name="cryptoCurrencyId">Cryptocurrency ID</param>
    /// <returns></returns>
    Task<Cryptocurrency?> GetCryptocurrencyAsync(Guid cryptoCurrencyId);
}