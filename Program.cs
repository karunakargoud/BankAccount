using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account account = new Account();
            Account P;
            
            SavingsAccount S1 = new SavingsAccount(90001, "Sai", 10000);
            //S1.ShowAccount();
            //S1.Deposit(1000);
            //S1.Withdraw(1000);
            //Console.WriteLine(S1.GetHashCode());

            SalaryAccount Emp1 = new SalaryAccount(30001, "Karun", 20000);
            //Emp1.ShowAccount();
            //Emp1.Deposit(2000);
            //Emp1.Withdraw(3000);
            //Console.WriteLine(Emp1.GetHashCode());

            CurrentAccount Cur1 = new CurrentAccount(10002, "King", 30000);
            //Cur1.ShowAccount();
            //Cur1.Deposit(1000);
            //Cur1.Withdraw(4000);
            //Console.WriteLine(Cur1.GetHashCode());

            // this is object polymorphism because parent class stores savingsAccount,SalaryAccount,CurrentAccount//
            Console.WriteLine(S1.GetHashCode()+" "+Emp1.GetHashCode()+" "+Cur1.GetHashCode());
            P = S1;
            Console.WriteLine("P=S1"+P.GetHashCode() + " " + S1.GetHashCode());
            P.ShowAccount();
            P.Deposit(1000);
            P.Withdraw(3000);

            P = Emp1;
            Console.WriteLine("P=Emp1"+P.GetHashCode() + " " + Emp1.GetHashCode());
            P.ShowAccount();
            P.Deposit(2000);
            P.Withdraw(4000);

            P = Cur1;
            Console.WriteLine("P=Cur1"+P.GetHashCode() + " " + Cur1.GetHashCode());
            P.ShowAccount();
            P.Deposit(5000);
            P.Withdraw(6000);
        }
    }
}
