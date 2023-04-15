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
            throw new ArgumentOutOfRangeException("Cannot instantinate Rial with a negative value.");
        
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
    
    /// <summary>
    /// Exchange the <see cref="Value"/> in Rial to the specified <see cref="Currency"/> by it's <paramref name="currencyCode"/>.
    /// If the <see cref="RialExchangeRate"/> for the <paramref name="currencyCode"/> has not been set before,
    /// it will raise <see cref="ExchangeRateNotFoundException"/>.
    /// </summary>
    /// <param name="currencyCode"><see cref="Currency"/> code that the value will convert</param>
    /// <returns>The Equavalant value in the given <paramref name="currencyCode"/></returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ExchangeRateNotFoundException"></exception>
    public decimal ExchangeTo(string currencyCode) {
        if (currencyCode.IsNullOrEmpty())
            throw new ArgumentNullException(nameof(currencyCode));

        var exchangeRate = TomanExchangeSource.GetRate(currencyCode);
        if (exchangeRate is null)
            throw new ExchangeRateNotFoundException(currencyCode);

        return Value / exchangeRate.Rate;
    }

    /// <summary>
    /// Creates a <see cref="Rial"/> object from the given <paramref name="currencyCode"/>.
    /// If a <see cref="Currency"/> with this code not found it will raise <see cref="CurrencyNotFoundException"/>,
    /// or If the <see cref="RialExchangeRate"/> has not been set before it will raise <see cref="ExchangeRateNotFoundException"/>
    /// </summary>
    /// <param name="currencyCode"></param>
    /// <param name="amount"></param>
    /// <returns>A <see cref="Rial"/> object with a <see cref="Value"/> correspond to the <paramref name="amount"/> multipy and the <see cref="RialExchangeRate"/> of the given <paramref name="currencyCode"/></returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    /// <exception cref="ExchangeRateNotFoundException"></exception>
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