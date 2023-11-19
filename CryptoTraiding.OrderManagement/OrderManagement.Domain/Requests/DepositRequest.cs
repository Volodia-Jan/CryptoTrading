using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using OrderManagement.Domain.Validators;

namespace OrderManagement.Domain.Requests;

/// <summary>
/// Represents deposit request data
/// </summary>
public class DepositRequest
{
    /// <summary>
    /// Wallet account ID
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    [DisplayName("Wallet account ID")]
    public Guid WalletAccountId { get; set; }

    /// <summary>
    /// Deposit amount(in USD)
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    [DecimalRange(ErrorMessage = "{0} must be between {1} and {2}")]
    [DisplayName("Deposit amount")]
    public decimal DepositAmount { get; set; }
}