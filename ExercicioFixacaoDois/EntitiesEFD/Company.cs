using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoDez.ExercicioFixacaoDois.EntitiesEFD
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {

        }
        public Company(string externalNameTaxPayer, double externalAnualIncome, int externalNumberOfEmployees)
        : base(externalNameTaxPayer, externalAnualIncome)
        {
            NumberOfEmployees = externalNumberOfEmployees;
        }

        public override double Tax()
        {
            double result =0;
            if(NumberOfEmployees <= 10)
            {
                result = AnualIncome * 0.16;
            }
            else if(NumberOfEmployees > 10)
            {
                result = AnualIncome * 0.14;
            }
            return result;
        }
    }
}