using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class SalaryAccount:Account
    {
        public SalaryAccount(int AccountNumber, string Name, double Balance) : base(AccountNumber, Name, Balance)
        {
        }
        public override void Withdraw(double Amount)
        {
            if ((Balance - Amount) > 300)
            {
                Balance = Balance - Amount;
                Console.WriteLine("After withdraw Balance : "+Balance);
            }
            else
            {
                Console.WriteLine("Min balance is required");
            }

        }
    }
}
