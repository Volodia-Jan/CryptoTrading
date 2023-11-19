using System.Text.Json.Serialization;

namespace OrderManagement.Domain.DTOs;

public class WalletAccountDto
{
    /// <summary>
    /// Account ID
    /// </summary>
    public Guid AccountId { get; set; }
    
    /// <summary>
    /// User ID
    /// </summary>
    public Guid UserId { get; set; }
    
    /// <summary>
    /// Balance that user is free to use(in USD)
    /// </summary>
    public decimal Balance { get; set; }
    
    /// <summary>
    /// Create date
    /// </summary>
    public DateTime CreationDate { get; set; }

    /// <summary>
    /// User's crypto wallets
    /// </summary>
    public List<WalletDto> Wallets { get; set; }
    
    /// <summary>
    /// User's all trades
    /// </summary>
    [JsonIgnore]
    public List<TradeDto> Trades { get; set; }
}