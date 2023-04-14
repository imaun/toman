using Xunit;

namespace Toman.Tests;

public class ExchangeRateTests
{

    [Theory]
    [InlineData("AED", 25000.1)]
    [InlineData("USD", 500000.2)]
    [InlineData("INR", 92000.1145)]
    public void exchange_rate_for_currency_can_be_found_when_set(string currencyCode, decimal rate) 
    {
        TomanExchangeSource.SetRate(currencyCode, rate);

        var exchangeRate = TomanExchangeSource.GetRate(currencyCode);
        Assert.NotNull(exchangeRate);
        Assert.Equal(exchangeRate!.Rate, rate);
    }

    [Theory]
    [InlineData("xyz", 25000.127)]
    [InlineData("73dj", 20000.89)]
    [InlineData("yutr", 8000)]
    public void exchange_rate_cannot_be_set_when_the_currency_not_exist(string currencyCode, decimal rate) 
    {
        Assert.Throws<CurrencyNotFoundException>(
            () => TomanExchangeSource.SetRate(currencyCode, rate));
    }
}
