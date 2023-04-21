namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBankAccount = new BankAccount();

            myBankAccount.Deposit(1000);
            Console.WriteLine( "Would you like to see your balance?");
            Console.WriteLine();
            Console.WriteLine();
            
            myBankAccount.Getbalance();
            


            int answer = Convert.ToInt32(Console.ReadLine()) ;
            Console.WriteLine();
            // myBankAccount.retrieve(500);
        }
    }
}
