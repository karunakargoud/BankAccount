using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal abstract class Account
    {
        protected int AccountNumber;
        protected string Name;
        protected double Balance;

        //constructor
        public Account(int AccountNumber, string Name, double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.Name = Name;
            this.Balance = Balance;
        }

        public void ShowAccount() //method
        {
            Console.WriteLine(AccountNumber + " " + Name + " " + Balance + " ");
        }
        public void Deposit(double Amount)//method
        {
            Console.WriteLine("Balance Before Deposit : " + Balance);
            Balance = Balance + Amount;
            Console.WriteLine("Balance After Deposit : " + Balance);
        }
        public abstract void Withdraw(double Amount);
    }
}
