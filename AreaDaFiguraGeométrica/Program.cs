using System;
using AreaDaFiguraGeometrica;

namespace AreaDaFiguraGeométrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo(20, 5);
            Console.WriteLine(t1.Area());

            Quadrado q1 = new Quadrado(20, 5);
            Console.Write(q1.Area());
        }
    }
}
