using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoDez.ExercicioResolvidoDois.EntitiesRD;
using CSharpSecaoDez.ExercicioResolvidoDois.EntitiesRD.EnumsRD;

namespace CSharpSecaoDez.ExercicioResolvidoDois
{
    class ExercicioResolvidoDois
    {
        public static void ExecutarExercicioResolvidoDois()
        {
            Console.Write("Enter the number of shapes: ");
            int nShapes = int.Parse(Console.ReadLine());

            List<ShapeOne> shapeL = new List<ShapeOne>();

            for(int cont = 1; cont <= nShapes; cont++)
            {
                Console.WriteLine($"Shape #{cont} data: ");
                Console.Write("Rectangle or Circle (r/c): ");
                char sChoice = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color cChoice = Enum.Parse<Color>(Console.ReadLine());

                if(sChoice == 'r')
                {
                    Console.Write("Width: ");
                    double wShape = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double hShape = double.Parse(Console.ReadLine());
                    
                    shapeL.Add(new Rectangle(cChoice, wShape,hShape));
                }
                if(sChoice == 'c')
                {
                    Console.Write("Radius: ");
                    double rShape = double.Parse(Console.ReadLine());

                    shapeL.Add(new Circle(cChoice,rShape));
                }                
            }
            Console.WriteLine();

            Console.WriteLine("SHAPE AREAS: ");
            foreach(ShapeOne sh in shapeL)
            {
                Console.WriteLine("Área: " + sh.Area().ToString("F2"));
            }

        }
    }
}