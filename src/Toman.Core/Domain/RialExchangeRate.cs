using System;

namespace Toman;

/// <summary>
/// Represents exchange rate for <see cref="Rial"/> against another international <see cref="Currency"/>.
/// </summary>
public class RialExchangeRate
{

    public RialExchangeRate(Currency currency, decimal rate) {
        if (currency is null)
            throw new ArgumentNullException(nameof(currency));

        if (rate <= 0)
            throw new RialExchangeRateOutOfRangeException();

        this.Currency = currency;
        this.Rate = rate;
    }

    public Currency Currency { get; private set; }

    public decimal Rate { get; private set; } = 0;

    public DateTime LastUpdateDateTime { get; private set; }
}
