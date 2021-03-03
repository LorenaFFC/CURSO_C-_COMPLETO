using Heranca.Entities;
using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Lorena", 800.0);
            Account acc2 = new SavingsAccount(1002, "Ana", 800.0, 0.02);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance) ;
            Console.WriteLine(acc2.Balance);
            /* Account acc = new Account(1000, "LORENA", 0);
             BusinessAccount bacc = new BusinessAccount(1001, "MARIA", 0.0, 500.0);

             // UPCASTING
             Account acc1 = bacc;
             Account acc2  = new BusinessAccount(1003, "MARIA", 0.0, 500.0);
             Account acc3 = new SavingsAccount(1004, "anna", 0.0, 0.03);


             // DOWNCASTING

             BusinessAccount acc4 = (BusinessAccount)acc2;

             acc4.Loan(200.00);*/

        }
    }
}
