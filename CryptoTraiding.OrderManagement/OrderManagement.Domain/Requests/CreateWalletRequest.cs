using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Domain.Requests;

/// <summary>
/// Represents create wallet request data
/// </summary>
public class CreateWalletRequest
{
    /// <summary>
    /// Wallet account ID
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    [DisplayName("Wallet account ID")]
    public Guid WalletAccountId { get; set; }

    /// <summary>
    /// Crypto currency ID
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    [DisplayName("Crypto currency ID")]
    public Guid CryptoId { get; set; }
}