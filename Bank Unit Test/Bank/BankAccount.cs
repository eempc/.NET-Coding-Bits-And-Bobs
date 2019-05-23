using System;

namespace Bank {
    public class Program {
        static void Main() {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);
            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);


        }
    }

    public class BankAccount {
        // Test strings
        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
        public const string DebitAmountLessThanZeroMessage = "Debit amount is less than zero";

        // Properties
        private readonly string m_customerName;
        private double m_balance;

        // Empty constructor
        public BankAccount() {
        }

        public BankAccount(string customerName, double balance) {
            m_customerName = customerName;
            m_balance = balance;
        }

        // I wonder why it's done this way and not just making the above properties public
        public string CustomerName {
            get { return m_customerName; }
        }

        public double Balance {
            get { return m_balance; }
        }

        public void Debit(double amount) {
            if (amount > m_balance) throw new ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
            if (amount < 0) throw new ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
            m_balance -= amount; // The wrong code is in here
        }

        public void Credit(double amount) {
            if (amount < 0) throw new ArgumentOutOfRangeException("amount");
            m_balance += amount;
        }

    }
}
