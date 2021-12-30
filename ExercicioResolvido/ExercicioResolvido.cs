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
            Employee emp = new OutsourcedEmployee();
            Employee emp2 = new Employee();

            Console.Write("Enter the number of employees : ");
            int nEmployee = int.Parse(Console.ReadLine());

            List<Employee> lista = new List<Employee>(nEmployee);
            for (int cont = 1; cont <= nEmployee; cont++)
            {
                Console.WriteLine($"Employee #{cont} data:");
                Console.Write("Outsourced (y/n)? ");
                string outSourcedSelect = Console.ReadLine();
                Console.Write("Name: ");
                string eName = Console.ReadLine();
                Console.Write("Hours: ");
                int eHours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double eVPerHour = double.Parse(Console.ReadLine());

                if (outSourcedSelect == "y" || outSourcedSelect == "Y")
                {
                    Console.Write("Additional charge: ");
                    double eAddCharge = double.Parse(Console.ReadLine());
                    emp = new OutsourcedEmployee(eName, eHours, eVPerHour, eAddCharge);
                    lista.Add(emp);
                }
                else
                {
                    emp2 = new Employee(eName, eHours, eVPerHour);
                    lista.Add(emp2);
                }

            }
            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach (Employee empO in lista)
            {
                Console.WriteLine(empO.EmployeeName + " - $" + empO.Payment());
            }

        }
    }
}