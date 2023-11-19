using AutoMapper;
using OrderManagement.Domain.DTOs;
using OrderManagement.Domain.Requests;
using OrderManagement.Domain.ServiceContracts;
using OrderManagement.Infrastructure.RepositoryContracts;

namespace OrderManagement.Domain.Services;

public class WalletsAccountsService : IWalletAccountsService
{
    private readonly IWalletAccountsRepository _accountsRepository;
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public WalletsAccountsService(IWalletAccountsRepository accountsRepository, IMapper mapper, IUserService userService)
    {
        _accountsRepository = accountsRepository;
        _mapper = mapper;
        _userService = userService;
    }

    public async Task<WalletAccountDto> CreateWalletAccountAsync()
    {
        var userId = _userService.GetAuthorizedUserId();
        // Checking if user has already account
        if (await _accountsRepository.GetWalletAccountByUserIdAsync(userId) is not null)
            throw new AggregateException($"User has already wallet account, userId: {userId}");

        var userAccount = await _accountsRepository.CreateWalletAccountAsync(new()
        {
            AccountId = Guid.NewGuid(),
            UserId = userId,
            Balance = 0m,
            CreationDate = DateTime.Now
        });

        if (userAccount is null)
            throw new ArgumentException("Wallet account creating failed");

        return _mapper.Map<WalletAccountDto>(userAccount);
    }

    public async Task<WalletAccountDto> DepositAsync(DepositRequest depositRequest)
    {
        var userAccount = await _accountsRepository.GetWalletAccountByIdAsync(depositRequest.WalletAccountId);
        if (userAccount is null)
            throw new ArgumentException($"Wallet account not found by id: {depositRequest.WalletAccountId}");

        userAccount.Balance += depositRequest.DepositAmount;
        var updatedAccount = await _accountsRepository.UpdateWalletAccountAsync(userAccount);
        if (updatedAccount is null)
            throw new ArgumentException($"Cannot update wallet account by id:{userAccount.AccountId}");

        return _mapper.Map<WalletAccountDto>(updatedAccount);
    }

    public async Task DeleteWalletAccountAsync()
    {
        var userId = _userService.GetAuthorizedUserId();
        var account = await _accountsRepository.GetWalletAccountByUserIdAsync(userId);
        if (account is null)
            throw new ArgumentException($"Cannot find account by user id:{userId}");

        if (!await _accountsRepository.DeleteWalletAccountAsync(account))
            throw new ArgumentException($"Cannot delete account by id:{account.AccountId}");
    }

    public async Task<WalletAccountDto> GetUserWalletAccountAsync()
    {
        var userId = _userService.GetAuthorizedUserId();
        var userAccount = await _accountsRepository.GetWalletAccountByUserIdAsync(userId);
        if (userAccount is null)
            throw new ArgumentException($"User account not found by user id{userId}");

        return _mapper.Map<WalletAccountDto>(userAccount);
    }

    public async Task<List<WalletAccountDto>> GetAllWalletAccountsAsync()
    {
        return _mapper.Map<List<WalletAccountDto>>(await _accountsRepository.GetAllWalletAccounts());
    }
}