namespace BankingApp
{
    public class CurrentAccount : IAccount
    {
        double bal;
        public CurrentAccount()
        {
            bal=200000;
        }

        public double Balance => bal;

        public double Deposit(double amount)
        {
            bal+=amount;
            return bal;
        }

        public double Withdraw(double amount)
        {
            if(amount<=bal)
            {
                if(bal-amount<10000)
                {
                    System.Console.WriteLine("failed");
                    System.Console.WriteLine("keep at leask 10k in account");
                }
                else{
                    System.Console.WriteLine("Success");
                    bal-=amount;
                }
            }
            return bal;
        }
    }
}