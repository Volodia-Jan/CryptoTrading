using System.Text;
using AccountManagement.Domain.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace CryptoTraiding.AccountManagment.AppStart;

/// <summary>
/// Represents authorization configuration
/// </summary>
public static class AuthorizationConfiguration
{
    /// <summary>
    /// Extension method to add JWT authorization
    /// </summary>
    /// <param name="services">Application services</param>
    /// <param name="configuration">Application configuration</param>
    public static void AddJwtAuthorization(this IServiceCollection services, IConfiguration configuration)
    {
        var jwtSection = configuration.GetSection(JWTOption.JWTOptionSecion);
        var symmetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSection["Key"]));
        
        services.AddAuthorization();
        services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtSection["Issuer"],
                    ValidAudience = jwtSection["Audience"],
                    IssuerSigningKey = symmetricKey
                };
            });
    }
}