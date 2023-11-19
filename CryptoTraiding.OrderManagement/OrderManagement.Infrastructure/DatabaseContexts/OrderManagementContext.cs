using System.Diagnostics;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Configuration;
using OrderManagement.Infrastructure.Entities;
using OrderManagement.Infrastructure.Entities.Enums;

namespace OrderManagement.Infrastructure.DatabaseContexts;

/// <summary>
/// Represents order management database context
/// </summary>
public class OrderManagementContext : DbContext
{ 
    public DbSet<WalletAccount> WalletAccounts { get; set; }
    public DbSet<Wallet> Wallets { get; set; }
    public DbSet<Cryptocurrency> Cryptocurrencies { get; set; }
    public DbSet<Trade> Trades { get; set; }
    
    public OrderManagementContext(DbContextOptions<OrderManagementContext> options): base(options) { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuring properties, relationships
        modelBuilder.Entity<WalletAccount>()
            .Property(x => x.Balance)
            .HasPrecision(20, 10);
        
        modelBuilder.Entity<Wallet>()
            .HasOne(w => w.WalletAccount)
            .WithMany(a => a.Wallets)
            .HasForeignKey(w => w.AccountId);
        
        modelBuilder.Entity<Wallet>()
            .HasOne(w => w.Cryptocurrency)
            .WithMany(c => c.Wallets)
            .HasForeignKey(w => w.CryptoId);
        
        modelBuilder.Entity<Wallet>()
            .Property(w => w.Amount)
            .HasPrecision(20, 10);

        modelBuilder.Entity<Trade>()
            .Property(t => t.TradeStatus)
            .HasConversion(new EnumToStringConverter<TradeStatus>());

        modelBuilder.Entity<Trade>()
            .Property(t => t.TradeType)
            .HasConversion(new EnumToStringConverter<TradeType>());

        modelBuilder.Entity<Trade>()
            .HasOne(t => t.WalletAccount)
            .WithMany(a => a.Trades)
            .HasForeignKey(t => t.AccountId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Trade>()
            .HasOne(t => t.Wallet)
            .WithMany(w => w.Trades)
            .HasForeignKey(t => t.WalletId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Trade>()
            .Property(t => t.Amount)
            .HasPrecision(20, 10);

        
        modelBuilder.Entity<Trade>()
            .Property(t => t.Price)
            .HasPrecision(20, 10);

        modelBuilder.Entity<Cryptocurrency>()
            .Property(c => c.Price)
            .HasPrecision(20, 10);
        
        // Add seed data
        var cryptosSeed = GetSeedData<List<Cryptocurrency>>("SeedData/cryptosSeed.json");
        var walletAccountsSeed = GetSeedData<List<WalletAccount>>("SeedData/walletAccountsSeed.json");
        var walletsSeed = GetSeedData<List<Wallet>>("SeedData/walletsSeed.json");
        var tradesSeed = GetSeedData<List<Trade>>("SeedData/tradesSeed.json");
        modelBuilder.Entity<Cryptocurrency>().HasData(cryptosSeed);
        modelBuilder.Entity<WalletAccount>().HasData(walletAccountsSeed);
        modelBuilder.Entity<Wallet>().HasData(walletsSeed);
        modelBuilder.Entity<Trade>().HasData(tradesSeed);
    }

    private T GetSeedData<T>(string fileName) where T : class, new()
    {
        T? seed;
        using (StreamReader reader = new(fileName))
        {
            var json = reader.ReadToEnd();
            seed = JsonSerializer.Deserialize<T>(json);
        }

        return seed ?? new T();
    }
}