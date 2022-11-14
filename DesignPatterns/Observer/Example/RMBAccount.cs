namespace Example
{
    public class RMBAccount : Subject
    {
        private double amount;

        public double Amount
        {
            get { return amount; }
            set
            {
                if (amount != value)
                {
                    amount = value;
                    Notify();
                }
            }
        }
    }
}
