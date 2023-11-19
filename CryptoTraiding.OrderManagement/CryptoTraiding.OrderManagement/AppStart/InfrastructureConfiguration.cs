using Microsoft.EntityFrameworkCore;
using OrderManagement.Infrastructure.DatabaseContexts;
using OrderManagement.Infrastructure.Repositories;
using OrderManagement.Infrastructure.RepositoryContracts;

namespace CryptoTrading.OrderManagement.AppStart;

/// <summary>
/// Represents static infrastructure configuration
/// </summary>
public static class InfrastructureConfiguration
{
    /// <summary>
    /// Extension method for adding infrastructure layer
    /// </summary>
    /// <param name="services">Application services</param>
    /// <param name="configuration">Application configuration</param>
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // Registers repositories
        services.AddScoped<IWalletAccountsRepository, WalletAccountsRepository>();
        services.AddScoped<IWalletRepository, WalletRepository>();
        services.AddScoped<ICryptocurrencyRepository, CryptocurrenciesRepository>();
        services.AddScoped<ITradesRepository, TradesRepository>();

        // Register DB contexts
        services.AddDbContext<OrderManagementContext>(option =>
            option.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
    }
}