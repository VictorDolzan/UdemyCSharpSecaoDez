using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoDez.ExercicioFixacao.EntitiesF
{
    class UsedProductF : ProductF
    {
        DateTime ManufactureDate { get; set;}

        public UsedProductF()
        {

        }

        public UsedProductF(string externalProdName, double externalProdPrice, DateTime externalManufactureDate)
        : base(externalProdName, externalProdPrice)
        {
            ManufactureDate = externalManufactureDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag()
            + $" (Manufacture date: " + ManufactureDate.ToString("MM/dd/yyyy")
            + ")";
        }
    }
}