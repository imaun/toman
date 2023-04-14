using System;

namespace Toman;

public class RialExchangeRateOutOfRangeException : Exception
{

	public RialExchangeRateOutOfRangeException()
		: base(message: "The ExchangeRate for Rial must be a positive decimal number above zero.")
	{
	}
}
