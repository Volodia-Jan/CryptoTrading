using Microsoft.EntityFrameworkCore;
using OrderManagement.Infrastructure.DatabaseContexts;
using OrderManagement.Infrastructure.Entities;
using OrderManagement.Infrastructure.Entities.Enums;
using OrderManagement.Infrastructure.RepositoryContracts;

namespace OrderManagement.Infrastructure.Repositories;

public class TradesRepository : ITradesRepository
{
    private readonly OrderManagementContext _db;

    public TradesRepository(OrderManagementContext db)
    {
        _db = db;
    }

    public async Task<List<Trade>> GetAllAccountTradesAsync(Guid walletAccountId) =>
        await _db.Trades
            .Include(x => x.WalletAccount)
            .Include(x => x.Wallet)
            .ThenInclude(x => x.Cryptocurrency)
            .Where(x => x.AccountId == walletAccountId)
            .ToListAsync();

    public async Task<List<Trade>> GetAllWalletTradesAsync(Guid walletId) =>
        await _db.Trades
            .Include(x => x.WalletAccount)
            .Include(x => x.Wallet)
            .ThenInclude(x => x.Cryptocurrency)
            .Where(x => x.WalletId == walletId)
            .ToListAsync();

    public async Task<Trade?> GetTradeAsync(Guid tradeId) =>
        await _db.Trades
            .Include(x => x.WalletAccount)
            .Include(x => x.Wallet)
            .ThenInclude(x => x.Cryptocurrency)
            .FirstOrDefaultAsync(x => x.TradeId == tradeId);

    public async Task<List<Trade>> GetAllTradesAsync() =>
        await _db.Trades
            .Include(x => x.WalletAccount)
            .Include(x => x.Wallet)
            .ThenInclude(x => x.Cryptocurrency)
            .ToListAsync();

    public async Task<List<Trade>> GetAllTradesByTypeAsync(TradeType tradeType)=>
        await _db.Trades
            .Include(x => x.WalletAccount)
            .Include(x => x.Wallet)
            .ThenInclude(x => x.Cryptocurrency)
            .Where(x => x.TradeType == tradeType)
            .ToListAsync();

    public async Task<List<Trade>> GetAllTradesByStatusAsync(TradeStatus tradeStatus) =>
        await _db.Trades
            .Include(x => x.WalletAccount)
            .Include(x => x.Wallet)
            .ThenInclude(x => x.Cryptocurrency)
            .Where(x => x.TradeStatus == tradeStatus)
            .ToListAsync();
    
    public async Task<Trade?> CreateTradeAsync(Trade trade)
    {
        _db.Trades.Add(trade);
        var result = await _db.SaveChangesAsync();

        return result > 0 ? trade : null;
    }

    public async Task<Trade?> UpdateTradeAsync(Trade trade)
    {
        _db.Trades.Update(trade);
        var result = await _db.SaveChangesAsync();

        return result > 0 ? trade : null;
    }

    public async Task<bool> DeleteTradeAsync(Trade trade)
    {
        _db.Trades.Remove(trade);
        var result = await _db.SaveChangesAsync();

        return result > 0;
    }
}