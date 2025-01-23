namespace BankingApp
{
    public class SavingAccount : IAccount
    {
        private double bal;
        public SavingAccount()
        {
            bal = 50000; // Default balance
        }

        public double Balance => bal;

        public double Deposit(double amount)
        {
            bal += amount;
            return bal;  // Optionally you can omit the return statement here if you don't need it
        }

        public double Withdraw(double amount)
        {
            if (amount <= bal)
            {
                if (bal - amount < 10000)
                {
                    System.Console.WriteLine("Failed");
                    System.Console.WriteLine("Keep at least 10k in account");
                }
                else
                {
                    System.Console.WriteLine("Success");
                    bal -= amount;
                }
            }
            else
            {
                System.Console.WriteLine("Insufficient balance");
            }
            return bal;  // You can choose to return only when needed, as the balance can be accessed directly
        }
    }
}
