using AutoMapper;
using OrderManagement.Domain.DTOs;
using OrderManagement.Infrastructure.Entities;

namespace OrderManagement.Domain.Mappers;

/// <summary>
/// Represents application mapper profile
/// </summary>
public class OrdersManagementMapper : Profile
{
    /// <summary>
    /// Configuration application mappers
    /// </summary>
    public OrdersManagementMapper()
    {
        CreateMap<Cryptocurrency, CryptocurrencyDto>();
        
        CreateMap<Trade, TradeDto>()
            .ForMember(dto => dto.CryptoDto, src =>
                src.MapFrom<Cryptocurrency>(e => e.Wallet.Cryptocurrency));

        CreateMap<Wallet, WalletDto>()
            .ForMember(dto => dto.Trades, src =>
                src.MapFrom<List<Trade>>(e => e.Trades))
            .ForMember(dto => dto.CryptoDto, src =>
                src.MapFrom<Cryptocurrency>(e => e.Cryptocurrency));
        
        CreateMap<WalletAccount, WalletAccountDto>()
            .ForMember(dto => dto.Trades, src =>
                src.MapFrom<List<Trade>>(e => e.Trades))
            .ForMember(dto => dto.Wallets, src =>
                src.MapFrom<List<Wallet>>(e => e.Wallets));
    }
}