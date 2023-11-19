using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Infrastructure.Entities;

/// <summary>
/// Represents crypto wallet
/// </summary>
public class Wallet
{
    /// <summary>
    /// Wallet ID
    /// </summary>
    [Key]
    public Guid WalletId { get; set; }
    
    /// <summary>
    /// Account ID
    /// </summary>
    public Guid AccountId { get; set; }
    
    /// <summary>
    /// Crypto currency ID
    /// </summary>
    public Guid CryptoId { get; set; }
    
    /// <summary>
    /// Creation date
    /// </summary>
    public DateTime CreationDate { get; set; }
    
    /// <summary>
    /// Amount
    /// </summary>
    public decimal Amount { get; set; }
    
    /// <summary>
    /// Wallet account data
    /// </summary>
    public WalletAccount WalletAccount { get; set; }
    
    /// <summary>
    /// Cryptocurrency data
    /// </summary>
    public Cryptocurrency Cryptocurrency { get; set; }

    /// <summary>
    /// Wallet trades
    /// </summary>
    public List<Trade> Trades { get; set; }
}