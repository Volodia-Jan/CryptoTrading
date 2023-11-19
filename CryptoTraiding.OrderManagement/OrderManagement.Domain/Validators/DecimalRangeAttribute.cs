using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Domain.Validators;

/// <summary>
/// Custom decimal range validation attribute
/// </summary>
public class DecimalRangeAttribute : ValidationAttribute
{
    /// <summary>
    /// Gets or sets minimal limit of range(not included)
    /// </summary>
    public decimal Min { get; set; }
    
    /// <summary>
    /// Gets or sets maximum limit of range(not included)
    /// </summary>
    public decimal Max { get; set; }

    /// <summary>
    /// Initializing of <see cref="DecimalRangeAttribute"/> class 
    /// </summary>
    public DecimalRangeAttribute()
    {
        Min = 0m;
        Max = decimal.MaxValue;
    }

    public override bool IsValid(object? value)
    {
        var decimalValue = (decimal?)value;
        if (decimalValue != null)
        {
            return decimalValue > Min && decimalValue < Max;
        }

        return true;
    }
}