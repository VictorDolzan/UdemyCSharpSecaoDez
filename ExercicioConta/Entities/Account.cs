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
        public virtual int NumberAccount { get; private set; }
        public virtual string Holder { get; private set; }
        public virtual double Balance { get; protected set; }

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
            Balance -= amount;
        }
        public virtual void Deposit(double amount)
        {
            Balance += amount; 
        }
    }
}