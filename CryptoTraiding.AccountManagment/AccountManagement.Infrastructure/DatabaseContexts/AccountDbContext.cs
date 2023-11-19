using System.Text.Json;
using AccountManagement.Infrastructure.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AccountManagement.Infrastructure.DatabaseContexts;

/// <summary>
/// Accounts database context
/// </summary>
public class AccountDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
{
    public DbSet<ApplicationUser> ApplicationUsers;
    public DbSet<ApplicationRole> ApplicationRoles;
    
    public AccountDbContext(DbContextOptions<AccountDbContext> dbContextOptions) : base(dbContextOptions) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        var users = GetUserSeedData("usersSeed.json");

        builder.Entity<ApplicationUser>().HasData(users);
    }
    
    /// <summary>
    /// Gets users seed data
    /// </summary>
    /// <param name="fileName">File name with seed data</param>
    /// <returns></returns>
    private static List<ApplicationUser> GetUserSeedData(string fileName)
    {
        List<ApplicationUser>? usersList;

        using (StreamReader reader = new(fileName))
        {
            var json = reader.ReadToEnd();
            usersList = JsonSerializer.Deserialize<List<ApplicationUser>>(json);
        }

        var passwordHasher = new PasswordHasher<ApplicationUser>();
        if (usersList is null)
            return new List<ApplicationUser>();

        foreach(var user in usersList)
        {
            user.NormalizedUserName = user.UserName?.ToUpper();
            user.NormalizedEmail = user.Email?.ToUpper();
            user.SecurityStamp = Guid.NewGuid().ToString("D");
            user.PasswordHash = passwordHasher.HashPassword(user, user.PasswordHash);
        }

        return usersList;
    }
}