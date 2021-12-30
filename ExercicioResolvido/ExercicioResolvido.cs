using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoDez.ExercicioResolvido.EntitiesR;

namespace CSharpSecaoDez.ExercicioResolvido
{
    class ExercicioResolvido
    {
        public static void ExecutarExercicioResolvido()
        {
            Console.Write("Enter the number of employees : ");
            int nEmployee = int.Parse(Console.ReadLine());

            List<Employee> lista = new List<Employee>(nEmployee);
            for (int cont = 1; cont <= nEmployee; cont++)
            {
                Console.WriteLine($"Employee #{cont} data:");
                Console.Write("Outsourced (y/n)? ");
                char outSourcedSelect = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string eName = Console.ReadLine();
                Console.Write("Hours: ");
                int eHours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double eVPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outSourcedSelect == 'y' || outSourcedSelect == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double eAddCharge = double.Parse(Console.ReadLine());
                    lista.Add(new OutsourcedEmployee(eName, eHours, eVPerHour, eAddCharge));                    
                }
                else
                {
                    lista.Add(new Employee(eName, eHours, eVPerHour));                    
                }

            }
            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach (Employee empO in lista)
            {
                Console.WriteLine(empO.EmployeeName + " - $" + empO.Payment().ToString("F2"));
            }

        }
    }
}