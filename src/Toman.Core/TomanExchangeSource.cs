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

    /// <summary>
    /// Set ExchangeRate for the given CurrencyCode. If the CurrencyCode is not one of the known
    /// currencies of the "Toman" (defined in <see cref="CurrencySource"/>), then a <see cref="CurrencyNotFoundException"/> will raise.
    /// </summary>
    /// <param name="currencyCode">Currency Code (Symbol) ex: USD for United States Dollar. It must be one of the known currencies defined in <see cref="CurrencySource"/></param>
    /// <param name="rate">The decimal Rate for the specified currency code.</param>
    /// <exception cref="ArgumentNullException">If the currency code is null or empty.</exception>
    /// <exception cref="CurrencyNotFoundException">If <see cref="Currency"/> not found in the known <see cref="CurrencySource"/></exception>
    public static void SetRate(string currencyCode, decimal rate) {
        if(currencyCode.IsNullOrEmpty())
            throw new ArgumentNullException(nameof(currencyCode));

        var currency = CurrencySource.FindByCode(currencyCode);
        if (currency is null)
            throw new CurrencyNotFoundException(currencyCode);

        SetRate(currency, rate);
    }

    /// <summary>
    /// Set ExchangeRate for the given <see cref="Currency"/>. If the Currency is not one of the known
    /// currencies of the "Toman" (defined in <see cref="CurrencySource"/>), then a <see cref="CurrencyNotFoundException"/> will raise.
    /// </summary>
    /// <param name="currency">It must be one of the known currencies defined in <see cref="CurrencySource"/></param>
    /// <param name="rate">The decimal Rate for the specified <see cref="Currency"/>.</param>
    /// <exception cref="CurrencyNotFoundException"></exception>
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

    /// <summary>
    /// Returns the <see cref="RialExchangeRate"/> info for the given <paramref name="currencyCode"/>.
    /// If the Currency is not one of the known currencies of the "Toman" (defined in <see cref="CurrencySource"/>), 
    /// then a <see cref="CurrencyNotFoundException"/> will raise.
    /// </summary>
    /// <param name="currencyCode">Currency Code (Symbol) ex: USD for United States Dollar. It must be one of the known currencies defined in <see cref="CurrencySource"/></param>
    /// <returns><see cref="RialExchangeRate"/> info for the given <paramref name="currencyCode"/> if found.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="CurrencyNotFoundException"></exception>
    public static RialExchangeRate? GetRate(string currencyCode) 
    {
        if (currencyCode.IsNullOrEmpty())
            throw new ArgumentNullException(nameof(currencyCode));

        var currency = CurrencySource.FindByCode(currencyCode);
        if (currency is null)
            throw new CurrencyNotFoundException(currencyCode);

        return GetRate(currencyCode);
    }

    /// <summary>
    /// Returns the <see cref="RialExchangeRate"/> info for the given <see cref="Currency"/>.
    /// </summary>
    /// <param name="currency">It must be one of the known currencies defined in <see cref="CurrencySource"/></param>
    /// <returns><see cref="RialExchangeRate"/> info for the given <see cref="Currency"/>, if found.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static RialExchangeRate? GetRate(Currency currency) {
        if (currency is null)
            throw new ArgumentNullException(nameof(currency));

        return _exchangeRates.ContainsKey(currency.Code) 
            ? _exchangeRates[currency.Code] 
            : null;
    }

    private static RialExchangeRate? FindByCurrencyCode(string currencyCode) {
        return _exchangeRates.Values
            .FirstOrDefault(c => c.Currency.Code.ToUpperInvariant() == currencyCode.ToUpperInvariant());
    }

    private static bool AlreadyHasExchangeRate(string currencyCode) {
        return FindByCurrencyCode(currencyCode) != null;
    }
}
