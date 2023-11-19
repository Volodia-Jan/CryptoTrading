using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Infrastructure.Entities;

/// <summary>
/// Represents crypto currency that is available in system
/// </summary>
public class Cryptocurrency
{
    /// <summary>
    /// Crypto ID
    /// </summary>
    [Key]
    public Guid CryptoId { get; set; }
    
    /// <summary>
    /// Crypto Name
    /// </summary>
    public string CryptoName { get; set; }
    
    /// <summary>
    /// Crypto symbol code
    /// </summary>
    public string SymbolCode { get; set; }
    
    /// <summary>
    /// Current price(in USD)
    /// </summary>
    public decimal Price { get; set; }
    
    /// <summary>
    /// Wallets data
    /// </summary>
    public List<Wallet> Wallets { get; set; }
}