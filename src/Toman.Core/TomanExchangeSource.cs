using System;
using System.Collections.Generic;
using System.Linq;

namespace Toman;

public static class TomanExchangeSource
{
    private static readonly IReadOnlyCollection<Currency> _currencies = CurrencySource.FindAll().ToList();
    private static Dictionary<string, decimal> _exchangeRates = new Dictionary<string, decimal>();

    public static void SetRate(string currencySymbol, decimal rate) 
    {

    }
}
