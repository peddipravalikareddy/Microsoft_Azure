// See https://aka.ms/new-console-template for more information
using Encapsulation;

//Console.WriteLine("Hello, World!");

//Creating an encapsulated BankAccount object
var account = new BankAccount("1234567890", "Pravali", 5000);
account.DisplayAccountInfo();

account.Deposit(1500);
account.Withdraw(2000);

//Trying to set an invalid name(this will throw an exception)
try
{
    account.AccountHolder = "";
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
//Trying to withdraw an amount greater than balance
account.Withdraw(10000);

account.DisplayAccountInfo();

