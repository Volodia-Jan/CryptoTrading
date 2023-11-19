using AutoMapper;
using OrderManagement.Domain.DTOs;
using OrderManagement.Domain.Requests;
using OrderManagement.Domain.ServiceContracts;
using OrderManagement.Infrastructure.RepositoryContracts;

namespace OrderManagement.Domain.Services;

public class WalletsService : IWalletsService
{
    private readonly IWalletRepository _walletRepository;
    private readonly IWalletAccountsRepository _walletAccountsRepository;
    private readonly ICryptocurrencyRepository _cryptocurrencyRepository;
    private readonly IMapper _mapper;

    public WalletsService(IWalletRepository walletRepository, IMapper mapper, IWalletAccountsRepository walletAccountsRepository, ICryptocurrencyRepository cryptocurrencyRepository)
    {
        _walletRepository = walletRepository;
        _mapper = mapper;
        _walletAccountsRepository = walletAccountsRepository;
        _cryptocurrencyRepository = cryptocurrencyRepository;
    }

    public async Task<WalletDto> CreateWalletAsync(CreateWalletRequest createWalletRequest)
    {
        // check if wallet account exist
        if (await _walletAccountsRepository.GetWalletAccountByIdAsync(createWalletRequest.WalletAccountId) is null)
            throw new ArgumentException($"Wallet account not found by id:{createWalletRequest.WalletAccountId}");
        
        // check if cryptocurrency exist
        var cryptoCurrency = await _cryptocurrencyRepository.GetCryptocurrencyAsync(createWalletRequest.CryptoId);
        if (cryptoCurrency is null)
            throw new ArgumentException($"Cryptocurrency not fount by id:{createWalletRequest.CryptoId}");
        
        // check if wallet account has already wallet for specific cryptocurrency
        if (await _walletAccountsRepository.IsWalletAccountHasCryptoWallet(createWalletRequest.WalletAccountId,
                createWalletRequest.CryptoId))
            throw new ArgumentException(
                $"This account({createWalletRequest.WalletAccountId} has already wallet for crypto:{createWalletRequest.CryptoId}");

        var wallet = await _walletRepository.CreateWalletAsync(new()
        {
            WalletId = Guid.NewGuid(),
            AccountId = createWalletRequest.WalletAccountId,
            CryptoId = createWalletRequest.CryptoId,
            Amount = 0m,
            CreationDate = DateTime.Now
        });

        if (wallet is null)
            throw new ArgumentException($"Cannot create wallet for account:{createWalletRequest.WalletAccountId}");

        wallet.Cryptocurrency = cryptoCurrency;

        return _mapper.Map<WalletDto>(wallet);
    }

    public async Task DeleteWalletAsync(Guid walletId)
    {
        var wallet = await _walletRepository.GetWalletById(walletId);
        if (wallet is null)
            throw new ArgumentException($"Wallet not found by id:{walletId}");

        if (!await _walletRepository.DeleteWalletAsync(wallet))
            throw new ArgumentException($"Cannot delete wallet by id:{walletId}");
    }

    public async Task<WalletDto> GetWalletByIdAsync(Guid walletId)
    {
        var wallet = await _walletRepository.GetWalletById(walletId);

        if (wallet is null)
            throw new ArgumentException($"Cannot create wallet for account:{walletId}");

        return _mapper.Map<WalletDto>(wallet);
    }

    public async Task<List<WalletDto>> GetWalletsByAccountId(Guid walletAccountId) =>
        _mapper.Map<List<WalletDto>>(await _walletRepository.GetWalletsByAccountId(walletAccountId));
}