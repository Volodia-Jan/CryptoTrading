using System.Text.Json.Serialization;

namespace OrderManagement.Infrastructure.Entities.Enums;

/// <summary>
/// Represents trade type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TradeType
{
    /// <summary>
    /// Type buy
    /// </summary>
    Buy,
    /// <summary>
    /// Type sell
    /// </summary>
    Sell
}