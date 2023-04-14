using System;

namespace Toman;

public class CurrencyNotFoundException : Exception
{

	public CurrencyNotFoundException() : base(message: "Currency not found.")
	{
	}

	public CurrencyNotFoundException(string currenyCode) 
		: base($"Currency with code '{currenyCode}' cannot be found.")
	{
	}
}
