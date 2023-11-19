using System.ComponentModel.DataAnnotations;
using OrderManagement.Infrastructure.Entities.Enums;

namespace OrderManagement.Infrastructure.Entities;

/// <summary>
/// Represents trade information
/// </summary>
public class Trade
{
    /// <summary>
    /// Trade ID
    /// </summary>
    [Key]
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
    /// Closed trade time
    /// </summary>
    public DateTime TradeDateTime { get; set; }

    /// <summary>
    /// Wallet account
    /// </summary>
    public WalletAccount WalletAccount { get; set; }
    
    /// <summary>
    /// Wallet
    /// </summary>
    public Wallet Wallet { get; set; }
}