using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoDez.ExercicioResolvidoDois.EntitiesRD.EnumsRD;

namespace CSharpSecaoDez.ExercicioResolvidoDois.EntitiesRD
{
    class Circle : ShapeOne
    {
        public double Radius { get; set; }

        public Circle()
        {

        }
        public Circle(Color externalColor, double externalRadius) : base(externalColor)
        {
            Radius = externalRadius;
        }

        public override double Area()
        {
            double pi = 3.14;
            return pi * Math.Pow(Radius, 2);
        }
    }
}