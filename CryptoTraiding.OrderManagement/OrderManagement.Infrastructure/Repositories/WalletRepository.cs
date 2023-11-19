using Microsoft.EntityFrameworkCore;
using OrderManagement.Infrastructure.DatabaseContexts;
using OrderManagement.Infrastructure.Entities;
using OrderManagement.Infrastructure.RepositoryContracts;

namespace OrderManagement.Infrastructure.Repositories;

public class WalletRepository : IWalletRepository
{
    private readonly OrderManagementContext _db;

    public WalletRepository(OrderManagementContext db)
    {
        _db = db;
    }

    public async Task<Wallet?> CreateWalletAsync(Wallet wallet)
    {
        _db.Wallets.Add(wallet);
        var result = await _db.SaveChangesAsync();
        
        return result > 0 ? wallet : null;
    }

    public async Task<Wallet?> UpdateWalletAsync(Wallet wallet)
    {
        _db.Wallets.Update(wallet);
        var result = await _db.SaveChangesAsync();

        return result > 0 ? wallet : null;
    }

    public async Task<bool> DeleteWalletAsync(Wallet wallet)
    {
        _db.Wallets.Remove(wallet);
        var result = await _db.SaveChangesAsync();

        return result > 0;
    }

    public async Task<Wallet?> GetWalletById(Guid walletId) =>
        await _db.Wallets
            .Include(x => x.Cryptocurrency)
            .Include(x => x.Trades)
            .FirstOrDefaultAsync(x => x.WalletId == walletId);

    public async Task<List<Wallet>> GetWalletsByAccountId(Guid walletAccountId) =>
        await _db.Wallets
            .Include(x => x.Cryptocurrency)
            .Include(x => x.Trades)
            .Where(x => x.AccountId == walletAccountId)
            .ToListAsync();
}