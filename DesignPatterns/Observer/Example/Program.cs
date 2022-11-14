using Example;

RMBAccount account = new RMBAccount()
{
    Amount = 1
};

var GBPCurrency = new Currency()
{
    Type = "GBP",
    ExchangeRate = 0.12
};
var EURCurrency = new Currency()
{
    Type = "EUR",
    ExchangeRate = 0.14
};
var RUBCurrency = new Currency()
{
    Type = "RUB",
    ExchangeRate = 8.41
};
account.Attach(new CurrencyObserver(account, GBPCurrency));
account.Attach(new CurrencyObserver(account, EURCurrency));
account.Attach(new CurrencyObserver(account, RUBCurrency));

account.Amount = 100;

Console.ReadKey();