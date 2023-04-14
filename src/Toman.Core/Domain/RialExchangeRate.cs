using System;

namespace Toman;

/// <summary>
/// Represents exchange rate for <see cref="Rial"/> against another international <see cref="Currency"/>.
/// </summary>
public class RialExchangeRate : IEquatable<RialExchangeRate>
{

    public RialExchangeRate(Currency currency, decimal rate) {
        if (currency is null)
            throw new ArgumentNullException(nameof(currency));

        if (rate <= 0)
            throw new RialExchangeRateOutOfRangeException();

        this.Currency = currency;
        this.Rate = rate;
        LastUpdateDateTime = DateTime.UtcNow;
    }

    public Currency Currency { get; private set; }

    public decimal Rate { get; private set; } = 0;

    /// <summary>
    /// Last update DateTime in UTC for this Rate
    /// </summary>
    public DateTime LastUpdateDateTime { get; private set; }

    public bool Equals(RialExchangeRate other) {
        if(other is null || other.GetType() != this.GetType())
            return false;

        if(!this.Currency.Equals(other.Currency)) return false;

        return this.Rate == other.Rate;
    }

    public override bool Equals(object obj) {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if(obj.GetType() != this.GetType()) return false;

        return Equals((RialExchangeRate)obj);
    }

    public override int GetHashCode() {
        return Rate.GetHashCode() + LastUpdateDateTime.GetHashCode();
    }
}
