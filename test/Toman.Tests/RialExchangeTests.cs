using System;
using Xunit;

namespace Toman.Tests;

public class RialExchangeTests
{

    [Theory]
    [InlineData(50000, 50000)]
    [InlineData(12000000, 500000)]
    [InlineData(200000000, 550000.25)]
    public void exchange_rial_to_usd_is_correct(long value, decimal usd_rate)
    {
        TomanExchangeSource.SetRate("USD", usd_rate);
        var rial = new Rial(value);
        var expected = value / usd_rate;
        var result = rial.ExchangeTo("USD");
        
        Assert.True(expected == result);
    }

    [Theory]
    [InlineData("usd", 500000, 10.5)]
    [InlineData("eur", 550000, 25.5)]
    [InlineData("inr", 2000, 40.6)]
    [InlineData("aed", 2250, 109.4)]
    public void rial_can_be_created_from_another_currency_when_exchange_rate_has_been_set(
        string currencyCode, decimal exchangeRate, decimal amount)
    {
        TomanExchangeSource.SetRate(currencyCode, exchangeRate);

        var rial = Rial.From(currencyCode, amount);
        var expected = Math.Round(amount * exchangeRate);
        
        Assert.True(rial.Value == expected);
    }
}
