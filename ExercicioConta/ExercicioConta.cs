using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoDez.ExercicioConta;
using CSharpSecaoDez.ExercicioConta.Entities;

namespace  CSharpSecaoDez.ExercicioConta
{
    class ExercicioConta
    {
        public static void ExecutarExercicioConta()
        {
            //Exercicio UPCASTING/ DOWNCASTING
            // Account acc = new Account(1001, "Alex", 0.0);
            // BussinessAccount bAcc = new BussinessAccount(1002, "Maria", 0.0, 500.00);

            // //UPCASTING

            // Account acc1 = bAcc;
            // Account acc2 = new BussinessAccount(1003, "Bob", 0, 200.00);
            // Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            // //DOWNCASTING

            // BussinessAccount acc4 = (BussinessAccount)acc2;
            // acc4.Loan(100.0);

            // if(acc3 is BussinessAccount)
            // {
            //     //BussinessAccount acc5 = (BussinessAccount)acc3;
            //     BussinessAccount acc5 = acc3 as BussinessAccount;
            //     acc5.Loan(200.0);
            //     Console.WriteLine("Loan!");
            // }
            // if(acc3 is SavingsAccount)
            // {
            //     //SavingsAccount acc5 = (SavingsAccount)acc3;
            //     SavingsAccount acc5 = acc3 as SavingsAccount;
            //     acc5.UpdateBalance();
            //     Console.WriteLine("Update!");
            // }

            //EXERCICIO SOBREPOSIÇÃO COM 'VIRTUAL' E 'OVERRIDE'

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Ana", 500.0, 0.01);

            acc1.Withdraw(10);
            acc2.Withdraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}