using System;
using System.ComponentModel.Design;
using Toman.Extensions;

namespace Toman;

/// <summary>
/// Iranian Rial. The Official currency for Iran (IRR).
/// </summary>
public class Rial : IEquatable<Rial>
{

    /// <summary>
    /// Creates a Rial object that holds a long integer value representing the amount in this currency.
    /// </summary>
    /// <param name="value"></param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public Rial(long value)
    {
        if (value < 0) 
            throw new ArgumentOutOfRangeException("Cannot instantinate Rial which has negative value.");
        
        Value = value;
    }
    
    /// <summary>
    /// Amount value in Rial currency.
    /// </summary>
    public long Value { get; private set; }


    /// <summary>
    /// Converts the value in Rial to Toman.
    /// </summary>
    /// <returns>The current value in Toman.</returns>
    public long InToman()
    {
        decimal divide = Value / 10;
        return Convert.ToInt64(Math.Floor(divide));
    }
    

    public decimal ExchangeTo(string currencyCode) {
        if (currencyCode.IsNullOrEmpty())
            throw new ArgumentNullException(nameof(currencyCode));

        var exchangeRate = TomanExchangeSource.GetRate(currencyCode);
        if (exchangeRate is null)
            throw new ExchangeRateNotFoundException(currencyCode);

        return Value / exchangeRate.Rate;
    }

    public static Rial From(string currencyCode, decimal amount) {
        if (currencyCode.IsNullOrEmpty())
            throw new ArgumentNullException(nameof(currencyCode));

        if (amount <= 0)
            throw new ArgumentOutOfRangeException("The Amount for exchange cannot be negative or zero.");

        var exchangeRate = TomanExchangeSource.GetRate(currencyCode);
        if (exchangeRate is null)
            throw new ExchangeRateNotFoundException(currencyCode);

        var valueInRial = CalculateFromRate(amount, exchangeRate.Rate);
        return new Rial(valueInRial);
    }
    

    private static long CalculateFromRate(decimal amount, decimal rate) {
        if (rate <= 0)
            throw new RialExchangeRateOutOfRangeException();

        return Convert.ToInt64(Math.Round(amount * rate));
    }

    public bool Equals(Rial? other)
    {
        if (other is null || other.GetType() != this.GetType())
            return false;

        return this.Value == other.Value;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Rial)obj);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}