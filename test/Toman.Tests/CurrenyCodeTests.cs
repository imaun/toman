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

    [Fact]
    public void AED_is_the_currency_code_for_Emirates() 
    {
        var dirham = Currency.WithCode("AED");

        Assert.NotNull(dirham);
        Assert.Equal("AED", dirham!.Code);
        Assert.Equal("United Arab Emirates dirham", dirham.EnglishName);
        Assert.Equal("United Arab Emirates", dirham.Locations[0]);
    }


    [Theory]
    [InlineData("784", "AED")]
    [InlineData("132", "CVE")]
    [InlineData("230", "ETP")]
    [InlineData("978", "EUR")]
    [InlineData("840", "USD")]
    [InlineData("356", "INR")]
    [InlineData("344", "HKD")]
    public void can_find_currency_with_the_numeric_code(string numericCode, string code) 
    {
        var currency = Currency.WithNumericCode(numericCode);
        Assert.NotNull(currency);
        Assert.Equal(code, currency!.Code);
    }
}