using System;

namespace ATM
{
    public class ATM
    {
        public ATM()
        {

        }

        public void Deposit(account acc, decimal deposit)
        {
            if (deposit <= 0)
                Console.WriteLine("Invalid deposit amount");
            else
                Console.WriteLine("{0:.2D} deposited. New Balance: {1:.2D}", deposit, acc.Deposit(deposit));
        }

        public void Withdrawl(account acc, decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawl amount");
                return;
            }
            var balance = acc.Withdrawl(amount);

            if(balance < 0)
                Console.WriteLine("Insufficient funds");
            else
                Console.WriteLine("Take cash dispensed, current balance: {0:.2D}",balance);
        }
    }
}