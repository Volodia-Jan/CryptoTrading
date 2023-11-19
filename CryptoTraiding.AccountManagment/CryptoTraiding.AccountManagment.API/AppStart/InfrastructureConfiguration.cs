using AccountManagement.Infrastructure.DatabaseContexts;
using AccountManagement.Infrastructure.Entities;
using AccountManagement.Infrastructure.Repositories;
using AccountManagement.Infrastructure.RepositoryContracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CryptoTraiding.AccountManagment.AppStart;

/// <summary>
/// Represents infrastructure configurations
/// </summary>
public static class InfrastructureConfiguration
{
    /// <summary>
    /// Extension method to add infrastructure
    /// </summary>
    /// <param name="services">Application services</param>
    /// <param name="configuration">Application configuration</param>
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IAccountRepository, AccountRepository>();
        
        services.AddDbContext<AccountDbContext>(option =>
        {
            option.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
        
        services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                options.Password.RequiredLength = 4;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = false;
            })
            .AddEntityFrameworkStores<AccountDbContext>()
            .AddDefaultTokenProviders()
            .AddUserStore<UserStore<ApplicationUser, ApplicationRole, AccountDbContext, Guid>>()
            .AddRoleStore<RoleStore<ApplicationRole, AccountDbContext, Guid>>();
    }
}