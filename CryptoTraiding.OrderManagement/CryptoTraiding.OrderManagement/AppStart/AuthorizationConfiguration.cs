using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace CryptoTrading.OrderManagement.AppStart;

/// <summary>
/// Represents authorization configuration
/// </summary>
public static class AuthorizationConfiguration
{
    /// <summary>
    /// Adds JWT authorization
    /// </summary>
    /// <param name="services">Application services</param>
    /// <param name="configuration">Application configuration</param>
    public static void AddJwtAuthorization(this IServiceCollection services, IConfiguration configuration)
    {
        var jwtSection = configuration.GetSection("JWT");
        var symmetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSection["Key"]));
        services.AddAuthorization();
        services.AddAuthentication(options => {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = symmetricKey,
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
    }
}