using AccountManagement.Infrastructure.DatabaseContexts;
using Microsoft.EntityFrameworkCore;

namespace CryptoTraiding.AccountManagment.AppStart;

/// <summary>
/// Represents migration configuration
/// </summary>
public static class MigrationConfiguration
{
    public static async Task AddMigration(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var services = scope.ServiceProvider;
        try
        {
            var dataContext = services.GetRequiredService<AccountDbContext>();
            await dataContext.Database.MigrateAsync();
        }
        catch(Exception ex)
        {
            var logger = services.GetService<ILogger<Program>>();
            logger.LogError(ex, "An error occured during migration in account management application");
        }
    }
}