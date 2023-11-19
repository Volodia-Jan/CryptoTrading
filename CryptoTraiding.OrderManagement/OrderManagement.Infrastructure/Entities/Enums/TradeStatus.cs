using System.Text.Json.Serialization;

namespace OrderManagement.Infrastructure.Entities.Enums;

/// <summary>
/// Represents trade status
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TradeStatus
{
    /// <summary>
    ///  Status open
    /// </summary>
    Open,
    /// <summary>
    /// Status closed
    /// </summary>
    Closed
}