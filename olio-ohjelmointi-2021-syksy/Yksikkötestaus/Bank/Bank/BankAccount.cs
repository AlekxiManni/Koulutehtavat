using System;

namespace BankAccountNS
{
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
        public const string DebitAmountLessThanZeroMessage = "Debit amount is less than zero";
        public const string DebitAmountExceeds100Dollar = "Debit amount is more than 100 Dollar";

        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
            }
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
            }
            if(amount > 100)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountExceeds100Dollar);
            }

            m_balance -= amount; 
        }

        public void Credit(double amount)
        {
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 110);

            ba.Credit(0);
            ba.Debit(101);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }
    }
}
