using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class CurrentAccount:Account
    {
        public CurrentAccount(int AccountNumber, string Name, double Balance) : base(AccountNumber, Name, Balance)
        {
        }
        public override void Withdraw(double Amount)
        {
            if ((Balance - Amount) > 0)
            {
                Balance = Balance - Amount;
                Console.WriteLine("After Withdraw Balance : "+Balance);
            }
            else
            {
                Console.WriteLine("Min balance is required");
            }

        }
    }
}
