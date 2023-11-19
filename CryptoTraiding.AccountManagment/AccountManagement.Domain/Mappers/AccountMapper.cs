using AccountManagement.Domain.DTOs;
using AccountManagement.Domain.Requests;
using AccountManagement.Infrastructure.Entities;
using AutoMapper;

namespace AccountManagement.Domain.Mappers;

/// <summary>
/// Represents application mapper profile
/// </summary>
public class AccountMapper : Profile
{
    /// <summary>
    /// Configuration application mappers
    /// </summary>
    public AccountMapper()
    {
        CreateMap(typeof(ApplicationUser), typeof(ApplicationUserDto));
        CreateMap(typeof(RegisterRequest), typeof(ApplicationUser));
    }
}