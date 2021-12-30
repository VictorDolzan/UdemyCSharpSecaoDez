using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoDez.ExercicioFixacao.EntitiesF
{
    class ImportedProductsF : ProductF
    {
        public double CustomsFee { get; set; }

        public ImportedProductsF()
        {

        }
        public ImportedProductsF(string externalProdName, double externalProdPrice, double externalCustomsFee)
        : base(externalProdName, externalProdPrice)
        {
            CustomsFee = externalCustomsFee;
        }

        public double TotalPrice()
        {
            return ProdPrice * CustomsFee;
        }

        public sealed override string PriceTag()
        {
            return base.PriceTag()
            + "( Customs Fee : $"
            + CustomsFee
            + ")";
        }
    }
}