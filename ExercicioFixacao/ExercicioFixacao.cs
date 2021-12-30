using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoDez.ExercicioFixacao.EntitiesF;

namespace CSharpSecaoDez.ExercicioFixacao
{
    class ExercicioFixacao
    {
        public static void ExecutarExercicioFixacao()
        {
            Console.Write("Enter the number of products: ");
            int nProd = int.Parse(Console.ReadLine());

            List<ProductF> lista = new List<ProductF>();

            for(int cont = 1; cont <= nProd; cont++)
            {
                Console.WriteLine($"Product #{cont} data: ");
                Console.Write("Common, used or imported (c/u/i) ");
                char pSelectStatus = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string pName = Console.ReadLine();
                Console.Write("Price: ");
                double pPrice = double.Parse(Console.ReadLine());

                if(pSelectStatus == 'i')
                {
                    Console.Write("Customs Fee: ");
                    double pCustomFee = double.Parse(Console.ReadLine());
                    lista.Add(new ImportedProductsF(pName, pPrice, pCustomFee));
                }
                else if(pSelectStatus == 'u')
                {
                    Console.Write("Manufacture Date (MM/DD/YYYY): ");
                    DateTime pManuDate = DateTime.Parse(Console.ReadLine());
                    lista.Add(new UsedProductF(pName, pPrice, pManuDate));
                }
                else if(pSelectStatus == 'c')
                {
                    lista.Add(new ProductF(pName, pPrice));
                }
            }
            Console.WriteLine();
            foreach(ProductF list in lista)
            {
                Console.WriteLine(list.PriceTag());
                ;
            }
        }
    }
}