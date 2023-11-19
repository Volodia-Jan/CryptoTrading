using System.Text.Json.Serialization;

namespace OrderManagement.Domain.DTOs;

public class WalletDto
{
    /// <summary>
    /// Wallet ID
    /// </summary>
    public Guid WalletId { get; set; }
    
    /// <summary>
    /// Account ID
    /// </summary>
    public Guid AccountId { get; set; }
    
    /// <summary>
    /// Cryptocurrency DTO
    /// </summary>
    public CryptocurrencyDto CryptoDto { get; set; }
    
    /// <summary>
    /// Creation date
    /// </summary>
    public DateTime CreationDate { get; set; }
    
    /// <summary>
    /// Amount
    /// </summary>
    public decimal Amount { get; set; }
    
    /// <summary>
    /// Trades
    /// </summary>
    [JsonIgnore]
    public List<TradeDto> Trades { get; set; }
}