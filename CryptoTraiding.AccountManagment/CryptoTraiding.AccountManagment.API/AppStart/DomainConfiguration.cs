using AccountManagement.Domain.Options;
using AccountManagement.Domain.ServiceContracts;
using AccountManagement.Domain.Services;

namespace CryptoTraiding.AccountManagment.AppStart;

public static class DomainConfiguration
{
    public static void AddDomain(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllers();
        
        // Register option models
        services.Configure<JWTOption>(configuration.GetSection(JWTOption.JWTOptionSecion));
        
        // Register services
        services.AddScoped<IAccountService, AccountService>();
        services.AddScoped<ITokenService, TokenService>();
        
        // Register mappers
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    }
}