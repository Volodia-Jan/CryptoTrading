using AccountManagement.Infrastructure.Entities;
using AccountManagement.Infrastructure.RepositoryContracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AccountManagement.Infrastructure.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task<ApplicationUser?> CreateUserAccountAsync(ApplicationUser applicationUser, string password)
    {
        var result = await _userManager.CreateAsync(applicationUser, password);

        return result.Succeeded ? applicationUser : null;
    }

    public async Task<bool> DeleteUserAccountAsync(ApplicationUser applicationUser) =>
        (await _userManager.DeleteAsync(applicationUser)).Succeeded;

    public async Task<ApplicationUser?> LoginAsync(string login, string password)
    {
        var result = await _signInManager.PasswordSignInAsync(login, password, isPersistent: false, lockoutOnFailure: false);

        return result.Succeeded
            ? _userManager.Users.FirstOrDefault(x => x.Email == login)
            : null;
    }

    public async Task LogoutAsync() => await _signInManager.SignOutAsync();
    
    public async Task<bool> IsEmailExistAsync(string email) => 
        await _userManager.Users.AnyAsync(x => x.Email == email);

    public async Task<ApplicationUser?> GetUserById(Guid id) =>
        await _userManager.Users.FirstOrDefaultAsync(x => x.Id == id);
}