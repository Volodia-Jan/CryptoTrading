using Microsoft.OpenApi.Models;

namespace CryptoTraiding.AccountManagment.AppStart;

/// <summary>
/// Represents swagger configuration
/// </summary>
public static class SwaggerConfiguration
{
    /// <summary>
    /// Add swagger
    /// </summary>
    /// <param name="services">Application services</param>
    public static void AddSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Crypto Traiding Account management API", Version = "v1" });
        });
    }
}