using Microsoft.EntityFrameworkCore;
using OrderManagement.Infrastructure.DatabaseContexts;
using OrderManagement.Infrastructure.Entities;
using OrderManagement.Infrastructure.RepositoryContracts;

namespace OrderManagement.Infrastructure.Repositories;

public class CryptocurrenciesRepository : ICryptocurrencyRepository
{
    private readonly OrderManagementContext _db;

    public CryptocurrenciesRepository(OrderManagementContext db)
    {
        _db = db;
    }

    public async Task<List<Cryptocurrency>> GetAllCryptocurrenciesAsync() =>
        await _db.Cryptocurrencies.ToListAsync();

    public async Task<Cryptocurrency?> GetCryptocurrencyAsync(Guid cryptoCurrencyId) =>
        await _db.Cryptocurrencies.FirstOrDefaultAsync(x => x.CryptoId == cryptoCurrencyId);
}