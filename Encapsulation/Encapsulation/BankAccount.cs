using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class BankAccount
    {
        private readonly string _accountNumber;
        private string _accountHolder;
        private decimal _balance;

        //Constructor

        public BankAccount(string accountNumber, string accountHolder, decimal initialBalance)
        {
            this._accountNumber = accountNumber;
            this._accountHolder = accountHolder;
            _balance = initialBalance > 0 ? initialBalance : throw new ArgumentException("Initial balance must be positive");

        }
        // encapsulated property with validation
        public string AccountHolder
        {
            get => _accountHolder;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Account holder name cannot be empty.");
                _accountHolder = value;
            }
        }
        // Read-only property
        public string AccountNumber => _accountNumber;

        //Read - only balance property (no public setter)
        public decimal Balance => _balance;

        //Encapsulated method for deposit
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit" + " amount must be positive.");
            _balance += amount;
            Console.WriteLine($"Deposited: {amount:C}," + $"New Balance: {_balance:C}");
        }

        //Encapsulated method for withdrawal with validation
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal" + "amount must be positive.");
            if(amount > _balance)
            {
                Console.WriteLine("Insufficient balance.");
                return false;
            }
            _balance -= amount;
            Console.WriteLine($"Withdrawn : {amount:C}, Remaining Balance: {_balance:C}");
            return true;
        }

        //Encapsulated method to display account details
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Holder:{AccountHolder}, Balance: {_balance:C}");
        }
    }
}
