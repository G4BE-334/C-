using System;

namespace NewBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Gabe", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} ");

            account.makeWithdrawal(120, DateTime.Now, "Hammock");

            //account.makeDeposit(-300, DateTime.Now, "Error");
            //Console.WriteLine(account.Balance);
            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -155);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}

            account.makeWithdrawal(300, DateTime.Now, "Xbox One X");

            Console.WriteLine(account.getAccountHistory());

            // Attempt to overdrawal
            //try
            //{
            //    account.makeWithdrawal(7500, DateTime.Now, "overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught by trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}        
            }

    }
}
