using AccountManagement.Domain.DTOs;
using AccountManagement.Domain.Requests;
using AccountManagement.Domain.ServiceContracts;
using AccountManagement.Infrastructure.Entities;
using AccountManagement.Infrastructure.RepositoryContracts;
using AutoMapper;
using Azure.Core;

namespace AccountManagement.Domain.Services;

public class AccountService : IAccountService
{
    private readonly IAccountRepository _accountRepository;
    private readonly ITokenService _tokenService;
    private readonly IMapper _mapper;

    public AccountService(IAccountRepository accountRepository, IMapper mapper, ITokenService tokenService)
    {
        _accountRepository = accountRepository;
        _mapper = mapper;
        _tokenService = tokenService;
    }

    public async Task<ApplicationUserDto> RegisterUserAsync(RegisterRequest registerDto)
    {
        if (await _accountRepository.IsEmailExistAsync(registerDto.Email))
            throw new ArgumentException($"Email ({registerDto.Email}) is already exist");
        
        var user = _mapper.Map<ApplicationUser>(registerDto);
        user.Id = Guid.NewGuid();
        user.CreatedAt = DateTime.Now;
        user.UserName = registerDto.Email;
        var createResult = await _accountRepository.CreateUserAccountAsync(user, registerDto.Password);

        if (createResult is null)
            throw new ArgumentException("Cannot register user");
    
        var userDto = _mapper.Map<ApplicationUserDto>(createResult);
        userDto.Token = _tokenService.GenerateToken(userDto.Id, userDto.Email);

        return userDto;
    }

    public async Task<ApplicationUserDto> LoginUserAsync(LoginRequest loginRequest)
    {
        var user = await _accountRepository.LoginAsync(loginRequest.Login, loginRequest.Password);

        if (user is null)
            throw new ArgumentException("Invalid login or password");
        
        var userDto = _mapper.Map<ApplicationUserDto>(user);
        userDto.Token = _tokenService.GenerateToken(userDto.Id, userDto.Email);

        return userDto;
    }

    public async Task DeleteUserAsync(Guid userId)
    {
        var user = await _accountRepository.GetUserById(userId);
        if (user is null)
            throw new ArgumentException($"User doesn't exist with id:{userId}");

        var result = await _accountRepository.DeleteUserAccountAsync(user);
        if (!result)
            throw new AggregateException($"Cannot delete user by id:{userId}");
    }

    public async Task LogOutAsync() => await _accountRepository.LogoutAsync();
}