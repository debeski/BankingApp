namespace BankingApp
{
    public class CurrentAccount : IAccount
    {
        private double bal;
        public CurrentAccount()
        {
            bal = 200000; // Default balance
        }

        public double Balance => bal;

        public double Deposit(double amount)
        {
            bal += amount;
            return bal;  // Optionally you can omit the return statement here
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
            return bal;  // You can choose to return only when needed
        }
    }
}
