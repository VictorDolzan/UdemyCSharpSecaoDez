using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoDez.ExercicioFixacaoDois.EntitiesEFD;

namespace CSharpSecaoDez.ExercicioFixacaoDois
{
    class ExercicioFixacaoDois
    {
        public static void ExecutarExercicioFixacaoDois()
        {
            Console.Write("Enter the number of tax payers:");
            int nTaxPayer = int.Parse(Console.ReadLine());

            List<TaxPayer> listTP = new List<TaxPayer>();

            for(int cont = 1; cont <= nTaxPayer; cont++)
            {
                Console.WriteLine($"Tax Payer #{cont} data: ");
                Console.Write("Individual or company (i/c)? ");
                char sTaxPayer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string tPName = Console.ReadLine();
                Console.Write("Anual Income: ");
                double aIncome = double.Parse(Console.ReadLine());

                if(sTaxPayer == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double hExpen = double.Parse(Console.ReadLine());

                    listTP.Add(new Individual(tPName, aIncome, hExpen));
                }
                else if( sTaxPayer == 'c')
                {
                    Console.Write("Number of employees: ");
                    int nEmplo = int.Parse(Console.ReadLine());

                    listTP.Add(new Company(tPName, aIncome, nEmplo));
                }                
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double tTax = 0;
            foreach(TaxPayer tp in listTP)
            {
                tTax += tp.Tax();
                Console.WriteLine(tp.NameTaxPayer
                + ": $"
                + tp.Tax().ToString("F2"));
            }
            Console.WriteLine();
            
            Console.WriteLine("TOTAL TAXES: $" + tTax );
            
        }
    }
}