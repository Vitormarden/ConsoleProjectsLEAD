using System;
using System.Collections.Generic;
using System.Text;

namespace AreaDaFiguraGeometrica
{
    internal class Quadrado : Geometria
    {
        public override double Area()
        {
            return Altura * Largura;
        }
        public Quadrado(double altura, double largura) : base(altura, largura)
        {

        }
    }
}
