using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Infrastructure.Entities;

/// <summary>
/// Represents user wallet account
/// </summary>
public class WalletAccount
{
    /// <summary>
    /// Account ID
    /// </summary>
    [Key]
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
    public List<Wallet> Wallets { get; set; }
    
    /// <summary>
    /// User's all trades
    /// </summary>
    public List<Trade> Trades { get; set; }
}