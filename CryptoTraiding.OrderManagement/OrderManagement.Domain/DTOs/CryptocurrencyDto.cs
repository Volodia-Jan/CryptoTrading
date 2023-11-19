namespace OrderManagement.Domain.DTOs;

/// <summary>
/// Represents cryptocurrency DTO
/// </summary>
public class CryptocurrencyDto
{
    /// <summary>
    /// Crypto ID
    /// </summary>
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
}