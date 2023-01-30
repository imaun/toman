using System.Linq;
using Xunit;

namespace Toman.Tests;

public class CurrencyCodeTests
{
    
    [Fact]
    public void IRR_is_the_iso_code_for_iranian_rial()
    {
        //The simplest test!
        var irr = Currency.WithCode("IRR");
        var expected = "Iranian Rial";
        Assert.Equal(expected, irr.EnglishName);
    }

    [Fact]
    public void Iran_standard_currency_code_is_IRR()
    {
        var all = Currency.GetAll();

        Currency? currency = null;
        foreach (var item in all)
        {
            if (item.Locations != null && item.Locations.Contains("Iran"))
                currency = item;
        }

        if (currency != null)
        {
            Assert.Equal("IRR", currency.Code);
            Assert.Equal("ریال", currency.Symbol);
        }
    }
}