using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using OrderManagement.Infrastructure.Entities.Enums;

namespace OrderManagement.Domain.Requests;

/// <summary>
/// Represents create trade request data
/// </summary>
public class CreateTradeRequest
{
    /// <summary>
    /// Wallet account ID
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    [DisplayName("Wallet account ID")]
    public Guid WalletAccountId { get; set; }
    
    /// <summary>
    /// Wallet ID
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    [DisplayName("Wallet ID")]
    public Guid WalletId { get; set; }
    
    /// <summary>
    /// Trade type
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    [DisplayName("Trade type")]
    public TradeType TradeType { get; set; }
    
    /// <summary>
    /// Amount
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    public decimal Amount { get; set; }
}