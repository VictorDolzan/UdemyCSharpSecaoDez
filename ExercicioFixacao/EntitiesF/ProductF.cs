using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoDez.ExercicioFixacao.EntitiesF
{
    class ProductF
    {
        public string ProdName { get; set; }
        public double ProdPrice { get; set; }

        public ProductF()
        {

        }
        public ProductF(string externalProdName, double externalProdPrice)
        {
            ProdName = externalProdName;
            ProdPrice = externalProdPrice;
        }

        public virtual string PriceTag()
        {
            return ProdName
            + " $"
            + ProdPrice.ToString("F2"); 

        }
    }
}