using System;
using System.Collections.Generic;

namespace BankAtmSimulation
{
    // Custom exception to handle insufficient bank balances cleanly
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }

    public class Account
    {
        public string AccountNumber { get; private set; }
        private string AccountHolder { get; set; }
        private decimal Balance { get; set; }
        private string Pin { get; set; }

        public Account(string accNum, string holder, decimal initialBalance, string pin)
        {
            AccountNumber = accNum;
            AccountHolder = holder;
            Balance = initialBalance;
            Pin = pin;
        }

        // Method to validate user identity
        public bool ValidatePin(string inputPin)
        {
            return Pin == inputPin;
        }

        // Processing a cash withdrawal with proper business rules and validation
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("❌ Invalid transaction amount.");
                return;
            }
            if (amount > Balance)
            {
                throw new InsufficientFundsException($"Transaction Failed: Tried to withdraw ₹{amount:N2} but available balance is ₹{Balance:N2}.");
            }

            Balance -= amount;
            Console.WriteLine($"✅ Successfully withdrew ₹{amount:N2}");
            Console.WriteLine($"Remaining Balance: ₹{Balance:N2}");
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Account: {AccountNumber} | Current Balance: ₹{Balance:N2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HDFC Digital ATM Terminal ===");
            
            // Mock database setup using a Dictionary
            Dictionary<string, Account> atmDatabase = new Dictionary<string, Account>()
            {
                { "123456", new Account("123456", "Karan Malhotra", 25000.00m, "9988") },
                { "789012", new Account("789012", "Ananya Sen", 4500.00m, "1122") }
            };

            // Simulating an active ATM user session
            string targetAccount = "789012";
            string enteredPin = "1122"; 

            Console.WriteLine($"Inserting card for account: {targetAccount}...");

            if (atmDatabase.ContainsKey(targetAccount))
            {
                Account activeAccount = atmDatabase[targetAccount];

                if (activeAccount.ValidatePin(enteredPin))
                {
                    Console.WriteLine("🔓 Access Granted.");
                    activeAccount.DisplayBalance();
                    Console.WriteLine();

                    // Simulating a safe transaction attempt inside a try-catch block
                    try
                    {
                        Console.WriteLine("Attempting to withdraw ₹5,000.00...");
                        activeAccount.Withdraw(5000.00m);
                    }
                    catch (InsufficientFundsException ex)
                    {
                        // Catching custom business logic exceptions safely
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("❌ Incorrect PIN. Access Denied.");
                }
            }
            else
            {
                Console.WriteLine("❌ Invalid Card / Account details not found.");
            }

            Console.WriteLine("\n=== Session Ended ===");
            Console.ReadKey();
        }
    }
}