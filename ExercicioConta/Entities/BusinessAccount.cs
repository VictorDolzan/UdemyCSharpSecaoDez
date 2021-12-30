using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoDez.ExercicioConta.Entities
{
    class BussinessAccount : Account
    {
        public double LoanLimit { get; set; }
        public BussinessAccount()
        {

        }
        public BussinessAccount(int externalNumber, string externalHolder, double externalBalance, double externalLoanLimit)
        : base(externalNumber, externalHolder, externalBalance)
        {
            LoanLimit = externalLoanLimit;
        }
        public void Loan(double amount)
        {
            if(amount < LoanLimit)
            {
                this.Balance += amount;
            }
            else
            {
                Console.WriteLine("Valor superior ao limite de empréstimo!");
            }
        }
        public override void Withdraw(double amount)
        {
            this.Balance -= amount;
        }
        public override void Deposit(double amount)
        {
            this.Balance += amount;
        }
    }
}