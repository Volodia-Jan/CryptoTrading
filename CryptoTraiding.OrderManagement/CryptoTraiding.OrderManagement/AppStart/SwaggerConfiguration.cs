using Microsoft.OpenApi.Models;

namespace CryptoTrading.OrderManagement.AppStart;

/// <summary>
/// Represents swagger configuration
/// </summary>
public static class SwaggerConfiguration
{
    /// <summary>
    /// Adds swagger
    /// </summary>
    /// <param name="services">Application services</param>
    public static void AddSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Crypto Traiding Orders management API", Version = "v1" });
            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "JWT Authorization header using the Bearer scheme. Enter the token with the `Bearer: ` prefix, e.g. \"Bearer abcde12345\""
            });
            c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                {
                    new OpenApiSecurityScheme {
                        Reference = new OpenApiReference {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    Array.Empty<string>()
                }
            });
        });
    }
}