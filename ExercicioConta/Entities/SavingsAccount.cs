using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoDez.ExercicioConta.Entities
{
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }
        public SavingsAccount(int externalNumber, string externalHolder, double externalBalance, double externalInterestRate)
        : base(externalNumber, externalHolder, externalBalance)
        {
            InterestRate = externalInterestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }       
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
        public override void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}