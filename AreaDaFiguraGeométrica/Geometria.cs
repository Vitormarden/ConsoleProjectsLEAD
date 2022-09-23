using System;
using System.Collections.Generic;
using System.Text;

namespace AreaDaFiguraGeometrica
{
    internal class Geometria
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public virtual double Area()
        {
            return Altura*Largura;
        }

        public Geometria(double altura, double largura)
        {
            this.Altura = altura;
            this.Largura = largura;
        }
    }

}
