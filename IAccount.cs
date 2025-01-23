namespace BankingApp
{
    public interface IAccount
    {
        double Balance { get; }
        double Withdraw(double amount);
        double Deposit(double amount);
    }
}