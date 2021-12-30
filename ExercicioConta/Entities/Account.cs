using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace  CSharpSecaoDez.ExercicioConta.Entities
{
    public class Account
    {
        public  int NumberAccount { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {

        }
        public Account(int externalNumber, string externalHolder, double externalBalance)
        {
            NumberAccount = externalNumber;
            Holder = externalHolder;
            Balance = externalBalance;
        }
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }
        public virtual void Deposit(double amount)
        {
            Balance += amount; 
        }
    }
}