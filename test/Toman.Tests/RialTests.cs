using System;
using Xunit;

namespace Toman.Tests;

public class RialTests
{
    
    [Fact]
    public void rial_cannot_be_created_with_negative_values()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Rial(-1));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Rial(-80000));
    }

    [Theory]
    [InlineData(10000)]
    [InlineData(893000)]
    [InlineData(0)]
    [InlineData(90000000)]
    public void rial_can_be_created_with_positive_value(long value)
    {
        var rial = new Rial(value);
        Assert.NotNull(rial);
        Assert.True(rial.Value == value);
    }

    [Theory]
    [InlineData(1000, 100)]
    [InlineData(10000, 1000)]
    [InlineData(100000, 10000)]
    [InlineData(1000000, 100000)]
    public void rial_in_toman_is_correct(long rial_val, long toman_val)
    {
        var rial = new Rial(rial_val);
        Assert.Equal(toman_val, rial.InToman());
    }
}