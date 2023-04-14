using System;
using System.Linq;
using Toman.Extensions;
using System.Collections.Concurrent;

namespace Toman;

/// <summary>
/// The static source of Exchange Rates for <see cref="Rial"/> currency.
/// </summary>
public static class TomanExchangeSource
{
    //private static readonly IReadOnlyCollection<Currency> _currencies = CurrencySource.FindAll().ToList();
    private static ConcurrentDictionary<string, RialExchangeRate> _exchangeRates = new();

    public static void SetRate(string currencyCode, decimal rate) 
    {
        if(currencyCode.IsNullOrEmpty())
            throw new ArgumentNullException(nameof(currencyCode));

        var currency = CurrencySource.FindByCode(currencyCode);
        SetRate(currency, rate);
    }


    public static void SetRate(Currency currency, decimal rate) {
        if (currency is null)
            throw new CurrencyNotFoundException();

        var exchangeRate = new RialExchangeRate(currency, rate);
        if (AlreadyHasExchangeRate(currency.Code)) {
            _exchangeRates[currency.Code] = exchangeRate;
            return;
        }

        _exchangeRates.TryAdd(currency.Code, exchangeRate);
    }

    private static RialExchangeRate? FindByCurrencyCode(string currencyCode) {
        return _exchangeRates.Values
            .FirstOrDefault(c => c.Currency.Code.ToUpperInvariant() == currencyCode.ToUpperInvariant());
    }

    private static bool AlreadyHasExchangeRate(string currencyCode) {
        return FindByCurrencyCode(currencyCode) != null;
    }
}
