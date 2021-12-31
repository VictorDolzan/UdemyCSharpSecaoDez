using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoDez.ExercicioFixacaoDois.EntitiesEFD
{
    abstract class TaxPayer
    {
        public string NameTaxPayer { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer()
        {

        }
        public TaxPayer(string externalNameTaxPayer, double externalAnualIncome)
        {
            NameTaxPayer = externalNameTaxPayer;
            AnualIncome = externalAnualIncome;
        }
        public abstract double Tax();
    }
}