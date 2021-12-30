using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoDez.ExercicioResolvido.EntitiesR
{
    class Employee
    {
        public string EmployeeName { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {

        }
        public Employee(string externalEmployeeName, int externalHours, double externalValuePerHour)
        {
            EmployeeName = externalEmployeeName;
            Hours = externalHours;
            ValuePerHour = externalValuePerHour;
        }
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
