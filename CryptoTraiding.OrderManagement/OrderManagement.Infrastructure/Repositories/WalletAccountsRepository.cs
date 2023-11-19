using Microsoft.EntityFrameworkCore;
using OrderManagement.Infrastructure.DatabaseContexts;
using OrderManagement.Infrastructure.Entities;
using OrderManagement.Infrastructure.RepositoryContracts;

namespace OrderManagement.Infrastructure.Repositories;

public class WalletAccountsRepository : IWalletAccountsRepository
{
    private readonly OrderManagementContext _db;

    public WalletAccountsRepository(OrderManagementContext db)
    {
        _db = db;
    }

    public async Task<WalletAccount?> CreateWalletAccountAsync(WalletAccount walletRepository)
    {
        _db.WalletAccounts.Add(walletRepository);
        var result = await _db.SaveChangesAsync();

        return result > 0 ? walletRepository : null;
    }

    public async Task<WalletAccount?> UpdateWalletAccountAsync(WalletAccount walletRepository)
    {
        _db.WalletAccounts.Update(walletRepository);
        var result = await _db.SaveChangesAsync();

        return result > 0 ? walletRepository : null;
    }

    public async Task<bool> DeleteWalletAccountAsync(WalletAccount walletRepository)
    {
        _db.WalletAccounts.Remove(walletRepository);
        var result = await _db.SaveChangesAsync();

        return result > 0;
    }

    public async Task<WalletAccount?> GetWalletAccountByIdAsync(Guid walletAccountId) =>
        await _db.WalletAccounts
            .Include(x => x.Wallets)
            .ThenInclude(x => x.Cryptocurrency)
            .FirstOrDefaultAsync(x => x.AccountId == walletAccountId);

    public async Task<WalletAccount?> GetWalletAccountByUserIdAsync(Guid userId)=>
        await _db.WalletAccounts
            .Include(x => x.Wallets)
            .ThenInclude(x => x.Cryptocurrency)
            .FirstOrDefaultAsync(x => x.UserId == userId);

    public async Task<bool> IsWalletAccountHasCryptoWallet(Guid walletAccountId, Guid cryptoId)
    {
        var account = await GetWalletAccountByIdAsync(walletAccountId);
        if (account is null)
            return false;

        return account.Wallets.Exists(x => x.CryptoId == cryptoId);
    }

    public async Task<List<WalletAccount>> GetAllWalletAccounts() => 
        await _db.WalletAccounts
            .Include(x => x.Wallets)
            .ThenInclude(x => x.Cryptocurrency)
            .ToListAsync();
}