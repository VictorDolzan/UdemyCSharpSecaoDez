using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoDez.ExercicioFixacaoDois.EntitiesEFD
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {

        }
        public Individual(string externalIndividualName, double externalAnualIncome, double externalHealthExpenditures)
        : base(externalIndividualName, externalAnualIncome)
        {
            HealthExpenditures = externalHealthExpenditures;
        }

        public override double Tax()
        {
            double result = 0;
            if (AnualIncome < 20000.00 && HealthExpenditures > 0)
            {
                 result += (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else if (AnualIncome < 20000.0)
            {
                result += AnualIncome * 0.15;
            }
            else if (AnualIncome > 20000.00 && HealthExpenditures > 0)
            {
                result += (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
            else if(AnualIncome > 20000.00)
            {
                result += AnualIncome * 0.5;
            }
            return result;
        }
    }
}