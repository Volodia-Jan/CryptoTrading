using OrderManagement.Domain.Mappers;
using OrderManagement.Domain.ServiceContracts;
using OrderManagement.Domain.Services;

namespace CryptoTraiding.OrderManagement.AppStart;

/// <summary>
/// Represents domain configuration
/// </summary>
public static class DomainConfigurations
{
    /// <summary>
    /// Adds domain layer
    /// </summary>
    /// <param name="services">Application services</param>
    public static void AddDomain(this IServiceCollection services)
    {
        services.AddControllers();
        // Registering services
        services.AddScoped<IWalletAccountsService, WalletsAccountsService>();
        services.AddScoped<IWalletsService, WalletsService>();
        services.AddScoped<ICryptocurrenciesService, CryptocurrenciesService>();
        services.AddScoped<ITradesService, TradesService>();
        services.AddScoped<IUserService, UserService>();

        // Registering mappers
        services.AddAutoMapper(typeof(OrdersManagementMapper).Assembly);
    }
}