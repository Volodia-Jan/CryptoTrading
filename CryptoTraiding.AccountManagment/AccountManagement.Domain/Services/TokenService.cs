using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AccountManagement.Domain.Options;
using AccountManagement.Domain.ServiceContracts;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace AccountManagement.Domain.Services;

public class TokenService : ITokenService
{
    private readonly JWTOption _jwtOption;

    public TokenService(IOptions<JWTOption> jwtOption)
    {
        _jwtOption = jwtOption.Value;
    }

    public string GenerateToken(Guid userId, string email)
    {
        var symmetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOption.Key));
        var claims = new List<Claim>
        {
            new(JwtRegisteredClaimNames.NameId, userId.ToString()),
            new(ClaimTypes.NameIdentifier, userId.ToString()),
            new(ClaimTypes.Email, email)
        };
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.Now.AddMinutes(_jwtOption.ExpirationTimeInMinutes),
            SigningCredentials =  new SigningCredentials(symmetricKey, SecurityAlgorithms.HmacSha512Signature)
        };
        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }
}