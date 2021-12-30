using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoDez.ExercicioResolvido.EntitiesR
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {

        }
        public OutsourcedEmployee(string externalName, int externalHour, double externalValuePerHour, double externalAdditionalCharge)
        : base (externalName, externalHour, externalValuePerHour)
        {
            AdditionalCharge = externalAdditionalCharge;
        }
        public sealed override double Payment()
        {   
            return (base.Payment()) + (AdditionalCharge * 1.10);
        }
    }
}