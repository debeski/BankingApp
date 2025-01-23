// See https://aka.ms/new-console-template for more information
using BankingApp;

Console.WriteLine("Banking App 2");
System.Console.WriteLine("Choose Account Type \n 1. Saving \n 2. Current");
IAccount account;

switch (int.Parse(Console.ReadLine()))
{
    case 1:
        account = new SavingAccount();
        break;
    case 2:
        account = new CurrentAccount();
        break;
    default:
        return;  // If an invalid choice is entered, the program ends
}

System.Console.WriteLine("1. Balance 2. Withdraw 3. Deposit");
int op = int.Parse(Console.ReadLine());

switch (op)
{
    case 1:
        System.Console.WriteLine("Balance: \t" + account.Balance);
        break;
    case 2:
        System.Console.Write("Enter amount to withdraw: ");
        account.Withdraw(double.Parse(Console.ReadLine()));
        break;
    case 3:
        System.Console.Write("Enter amount to deposit: ");
        account.Deposit(double.Parse(Console.ReadLine()));
        break;
    default:
        System.Console.WriteLine("Invalid Option");
        break;
}
