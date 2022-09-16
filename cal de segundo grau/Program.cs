using System;

namespace calculadora_de_expressao_de_segundo_grau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite c");
            double c = double.Parse(Console.ReadLine());

            double delta = Math.Pow(b, 2) - 4 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            if (delta == 0)
            {
                Console.WriteLine(x1);
            }
            else if (delta > 0)
            {
                Console.WriteLine($"x1: {x1}");
                Console.WriteLine($"x2: {x2}");
            }
            else
            {
                Console.WriteLine("não tem raiz");
            }
        }
    }
}
