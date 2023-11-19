using OrderManagement.Infrastructure.Entities.Enums;

namespace OrderManagement.Domain.DTOs;

public class TradeDto
{
    /// <summary>
    /// Trade ID
    /// </summary>
    public Guid TradeId { get; set; }
    
    /// <summary>
    /// Account ID
    /// </summary>
    public Guid AccountId { get; set; }
    
    /// <summary>
    /// Wallet ID
    /// </summary>
    public Guid WalletId { get; set; }
    
    /// <summary>
    /// Trade type
    /// </summary>
    public TradeType TradeType { get; set; }

    /// <summary>
    /// Trade status
    /// </summary>
    public TradeStatus TradeStatus { get; set; }
    
    /// <summary>
    /// Amount
    /// </summary>
    public decimal Amount { get; set; }
    
    /// <summary>
    /// Price
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Cryptocurrency DTO
    /// </summary>
    public CryptocurrencyDto CryptoDto { get; set; }
}