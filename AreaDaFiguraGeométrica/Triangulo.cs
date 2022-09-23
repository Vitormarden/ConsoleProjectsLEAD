using System;
using System.Collections.Generic;
using System.Text;

namespace AreaDaFiguraGeometrica
{
    internal class Triangulo : Geometria
    {
        public override double Area()
        {
            return (Altura * Largura) / 2;
        }
        public Triangulo(double altura, double largura) : base(altura, largura)
        {
         
        }
    }
}
