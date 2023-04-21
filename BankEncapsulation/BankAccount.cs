using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
		public BankAccount()
		{
		}
		private double balance = 0; // field


		public void Deposit(double amount)
		{
			balance += amount;

		}

        public void Getbalance()
		{
			Console.WriteLine($"please see your balance -- ${balance}");
		}


		

		public void retrieve(double amount)
		{
			balance -= amount;
		}

	}
}

