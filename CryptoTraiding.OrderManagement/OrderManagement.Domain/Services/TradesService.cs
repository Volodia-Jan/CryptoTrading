using AutoMapper;
using OrderManagement.Domain.DTOs;
using OrderManagement.Domain.Requests;
using OrderManagement.Domain.ServiceContracts;
using OrderManagement.Infrastructure.Entities.Enums;
using OrderManagement.Infrastructure.RepositoryContracts;

namespace OrderManagement.Domain.Services;

public class TradesService : ITradesService
{
    private readonly ITradesRepository _tradesRepository;
    private readonly IUserService _userService;
    private readonly IWalletAccountsRepository _accountsRepository;
    private readonly IMapper _mapper;

    public TradesService(ITradesRepository tradesRepository, IMapper mapper, IUserService userService,
        IWalletAccountsRepository accountsRepository)
    {
        _tradesRepository = tradesRepository;
        _mapper = mapper;
        _userService = userService;
        _accountsRepository = accountsRepository;
    }

    public async Task<TradeDto> CreateTradeAsync(CreateTradeRequest createTradeRequest)
    {
        // check if wallet account exist
        var walletAccount = await _accountsRepository.GetWalletAccountByIdAsync(createTradeRequest.WalletAccountId);
        if (walletAccount is null)
            throw new ArgumentException($"Wallet account not found by id:{createTradeRequest.WalletAccountId}");

        // check if wallet exist in this account
        var wallet = walletAccount.Wallets.Find(x => x.WalletId == createTradeRequest.WalletId);
        if (wallet is null)
            throw new ArgumentException($"Wallet not fount by id:{createTradeRequest.WalletId}");

        // if trade status sell, check wallet amount
        if (createTradeRequest.TradeType == TradeType.Sell && wallet.Amount < createTradeRequest.Amount)
            throw new ArgumentException("Not enough amount of cryptocurrency");

        var trade = await _tradesRepository.CreateTradeAsync(new()
        {
            TradeId = Guid.NewGuid(),
            AccountId = createTradeRequest.WalletAccountId,
            WalletId = createTradeRequest.WalletId,
            Amount = createTradeRequest.Amount,
            TradeType = createTradeRequest.TradeType,
            TradeStatus = TradeStatus.Open,
            TradeDateTime = DateTime.Now,
            Price = wallet.Cryptocurrency.Price * createTradeRequest.Amount
        });

        if (trade is null)
            throw new ArgumentException("Cannot create trade");

        // change data on wallet
        wallet.Amount -= createTradeRequest.Amount;
        wallet.Trades.Add(trade);
        await _accountsRepository.UpdateWalletAccountAsync(walletAccount);

        return _mapper.Map<TradeDto>(trade);
    }

    public async Task DeleteTradeAsync(Guid tradeId)
    {
        var trade = await _tradesRepository.GetTradeAsync(tradeId);
        if (trade is null)
            throw new ArgumentException($"Cannot find trade by id:{tradeId}");

        if (!await _tradesRepository.DeleteTradeAsync(trade))
            throw new ArgumentException($"Cannot delete trade by id{tradeId}");
    }

    public async Task<List<TradeDto>> GetAllTradesByStatusAsync(TradeStatus tradeStatus) =>
        _mapper.Map<List<TradeDto>>(await _tradesRepository.GetAllTradesByStatusAsync(tradeStatus));

    public async Task<List<TradeDto>> GetAllTradesByTypeAsync(TradeType tradeType) =>
        _mapper.Map<List<TradeDto>>(await _tradesRepository.GetAllTradesByTypeAsync(tradeType));

    public async Task<List<TradeDto>> GetAllTradesAsync() =>
        _mapper.Map<List<TradeDto>>(await _tradesRepository.GetAllTradesAsync());

    public async Task<TradeDto> GetTradeAsync(Guid tradeid)
    {
        var trade = await _tradesRepository.GetTradeAsync(tradeid);
        if (trade is null)
            throw new ArgumentException($"Cannot find trade by id:{tradeid}");

        return _mapper.Map<TradeDto>(trade);
    }

    public async Task<List<TradeDto>> GetAllWalletTradesAsync(Guid walletId) =>
        _mapper.Map<List<TradeDto>>(await _tradesRepository.GetAllWalletTradesAsync(walletId));

    public async Task<List<TradeDto>> GetAllWalletAccountTradesAsync(Guid walletAccountId) =>
        _mapper.Map<List<TradeDto>>(await _tradesRepository.GetAllAccountTradesAsync(walletAccountId));

    public async Task<TradeDto> CloseTradeAsync(Guid tradeId)
    {
        var trade = await _tradesRepository.GetTradeAsync(tradeId);
        if (trade is null)
            throw new ArgumentException($"Cannot find trade by id:{tradeId}");

        // check if trade isn't current user trade
        var userId = _userService.GetAuthorizedUserId();
        if (trade.WalletAccount.UserId == userId)
            throw new ArgumentException("You cannot close your own trade");
        
        // check if trade is open
        if (trade.TradeStatus == TradeStatus.Closed)
            throw new ArgumentException("This trade is already closed");

        // get user account
        var userAccount = await _accountsRepository.GetWalletAccountByUserIdAsync(userId);
        if (userAccount is null)
            throw new ArgumentException("You do not have wallet account");

        // check if user have enough money to close trade
        if (userAccount.Balance < trade.Price)
            throw new ArgumentException("You do not have enough money");

        // check if user have needed wallet
        var wallet = userAccount.Wallets.Find(x => x.CryptoId == trade.Wallet.CryptoId);
        if (wallet is null)
            throw new ArgumentException("You do not have needed wallet");

        // close trade, update data in DB
        trade.TradeStatus = TradeStatus.Closed;
        var updatedTrade = await _tradesRepository.UpdateTradeAsync(trade);
        if (updatedTrade is null)
            throw new ArgumentException($"Cannot close trade, trade ID:{tradeId}");

        // update user account and wallet
        userAccount.Balance -= trade.Price;
        userAccount.Trades.Add(updatedTrade);
        wallet.Amount += trade.Amount;
        await _accountsRepository.UpdateWalletAccountAsync(userAccount);

        return _mapper.Map<TradeDto>(updatedTrade);
    }
}