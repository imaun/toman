# Toman

### (تومن in persian)

**Toman** provides a way for working with Iranian currencies like Rial and Toman with other international currencies.
You can use it to keep money and financial related values in `Rial` or `Toman` in your applications. It handles 
all the common logics, conversations and exchanges with international currencies for you.
---

It contains all the information about the international currencies based on
[ISO 4217](https://en.wikipedia.org/wiki/ISO_4217).
You can access all of these currencies in the [`CurrencySource`](https://github.com/imaun/toman/blob/master/src/Toman.Core/CurrencySource.cs)
which is a static class. You can use it to find a specific currency by it's `curencyCode` or symbol.

<div dir="rtl">
    کتابخانه <b>تومن</b>  به شما کمک می کند تا با مقادیر پولی و مالی به شکل مناسب تری کاز کنید.
<b>تومن</b> لیستی از واحدهای بین المللی بر اساس استاندارد ISO 4217 را به شما ارائه می دهد که با استفاده از 
آن ها می توانید با تنظیم نرخ مبادله با ریال، از قابلیت های تبدیل این کتابخانه استفاده کنید.
</div>
### Features

- Representing ISO 4217 Currencies in a static class
- Find currencies based on it's symbol or numeric code
- Implements `Rial` class which encapsulates Iranian currency with a specific value
- Provides data source for keeping `ExchangeRates` against other international currencies [`TomanExchangeSource`](https://github.com/imaun/toman/blob/master/src/Toman.Core/TomanExchangeSource.cs) 
- Converts Rial values to Toman (Unofficial Iranian Currency)
- Converts Rial values to another international currency based on rates defined in `TomanExchangeSource`

### How to Use

You clone this repo, build it and add reference to the output assembly, or 
simply install it via nuget.

```
dotnet add package Toman
```

#### Finding all international currencies
```csharp
using Toman;

var all = CurrencySource.FindAll();
```

#### Find a currency based on it's symbol or code
```csharp
using Toman;

var usd = CurrencySource.FindByCode("USD");
```

#### Creating a Rial value
```csharp
using Toman;

var money = new Rial(100000);
Console.WriteLine($"Value: {money.Value}");
```

#### Setting an ExchangeRate for a specific Currency and creates Rial value from it
```csharp
using Toman;

TomanExchangeSource.SetRate("USD", 500000);
var rial = Rial.From("USD", amount: 120.56);
Console.WriteLine($"120.56 USD = {rial.Value} rial and {rial.InToman()} toman");
```

