using System.Collections.Generic;

namespace Toman;

internal static class CurrencySource
{



    private static IDictionary<string, Currency> _currencies = new Dictionary<string, Currency>
    {
        ["AED"] = new Currency()
    };
}