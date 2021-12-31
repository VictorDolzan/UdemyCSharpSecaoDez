using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoDez.ExercicioResolvidoDois.EntitiesRD.EnumsRD;

namespace CSharpSecaoDez.ExercicioResolvidoDois.EntitiesRD
{
    class Rectangle : ShapeOne
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {

        }
        public Rectangle(Color externalColor, double extrnalWidth, double externalHeigth) : base(externalColor)
        {
            Width = extrnalWidth;
            Height = externalHeigth;
        }

        public sealed override double Area()
        {
            return Width * Height;
        }
    }
}