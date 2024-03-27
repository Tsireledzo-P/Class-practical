namespace Credit;
using System;


public class Account
{
	public Account()
	{
		//declaring variables
		string name { get; set; }
		string type { get; set; }
		int accNum  { get; set; }
		double balance { get; set; }

		//constructor
		public Account(string name, string type, int accNum)
		{
			this.name = name;
			this.type = type;	
			this.accNum = accNum;
			this.balance = balance;
		}

		//methods
		public void deposit(double amount)
		{
		  if (amount > 0)
			{
				balance = amount;
				console.WriteLine("Deposited {amount} into account {accNum}.")
			}
			else
			{
                console.WriteLine("Deposited amount must be above zero")

            }
		}

		public void withdrawl(double amount)
		{
			if (amount > 0)
			{
				balance -= amount;
				console.WriteLine("Withdrawn {amount} from {accNum}.")
			}
			else if (amount < balance)
			{
				console.WriteLine("Not enough funds")
			}
			else
			{
				console.WriteLine("Withdrawl amount must be above zero")
			}
		}
	
	}
}
