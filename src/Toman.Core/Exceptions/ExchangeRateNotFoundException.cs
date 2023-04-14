using System;

namespace Toman;

public class ExchangeRateNotFoundException : Exception
{

	public ExchangeRateNotFoundException(string currencyCode) 
		: base(message: $"The ExchangeRate for '{currencyCode}' not found. Please set the ExchangeRate using TomanExchangeSource first.")
	{
	}
}
