using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using OrderManagement.Domain.ServiceContracts;

namespace OrderManagement.Domain.Services;

public class UserService : IUserService
{
    private readonly IHttpContextAccessor _http;

    public UserService(IHttpContextAccessor http)
    {
        _http = http;
    }

    public Guid GetAuthorizedUserId()
    {
        var claimId = _http.HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
        if (claimId is null)
            throw new ArgumentException("Cannot access to authorized user data, try to new token");

        var id = claimId.Value;
        if (string.IsNullOrEmpty(id.Trim()) || !Guid.TryParse(id, out var userId))
            throw new ArgumentException($"Invalid format of user id: {id}");

        return userId;
    }
}