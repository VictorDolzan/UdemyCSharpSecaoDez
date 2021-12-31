using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoDez.ExercicioResolvidoDois.EntitiesRD.EnumsRD;


namespace CSharpSecaoDez.ExercicioResolvidoDois.EntitiesRD
{
    abstract class ShapeOne
    {
        public Color color { get; set; }

        public ShapeOne()
        {

        }
        public ShapeOne(Color externalColor)
        {
            color = externalColor;
        }

        public abstract double Area();
        
    }
}