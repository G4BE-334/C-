using System;
using System.Collections.Generic;
using System.Text;

namespace NewBank
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in History)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }
        private static int accountSeed = 1234567890;

        private List<Transaction> History = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            makeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            this.Number = accountSeed.ToString();
            accountSeed++;
        }
        public void makeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            History.Add(deposit);
        }
        public void makeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            History.Add(withdrawal);
        }
        
        public string getAccountHistory()
        {
            var report = new StringBuilder();
            
            // Header
            report.AppendLine("Date\t\tAmount\tNote");
            foreach (var item in History)
            {
                // Rows
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
            }
            return report.ToString();
        }
    }
}
