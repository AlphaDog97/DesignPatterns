namespace Example
{
    public class CurrencyObserver : Observer
    {
        private Currency currency;
        private RMBAccount rmbSubject;

        public CurrencyObserver(RMBAccount rmbSubject, Currency currency)
        {
            this.rmbSubject = rmbSubject;
            this.currency = currency;
        }

        public override void Update()
        {
            Console.WriteLine($"{rmbSubject.Amount} RMBs transfer to {currency.Type} equals {Math.Round(rmbSubject.Amount * currency.ExchangeRate)}");
        }
    }
}
