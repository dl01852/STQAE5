namespace ATM
{
    public class account
    {
        public int PIN { get; private set; }
        public decimal Balance { get; private set; }

        public account(int pin)
        {
            PIN = pin;
        }

        public decimal Withdrawl(decimal amount)
        {
            if (Balance >= amount)
                Balance -= amount;
            else
                return -1;

            return Balance;
        }

        public decimal Deposit(decimal amount)
        {
            Balance += amount;

            return Balance;
        }

    }
}