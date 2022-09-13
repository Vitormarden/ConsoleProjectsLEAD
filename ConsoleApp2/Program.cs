using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua ocupação?");
            string ocupacao = Console.ReadLine();
            Console.WriteLine("Qual sua remuneração bruta?");

            double remuneracao_bruta = double.Parse(Console.ReadLine());

            double remuneracao_liquida = remuneracao_bruta; //= 

            if(remuneracao_bruta <= 1903.98)
            {
                remuneracao_liquida = remuneracao_bruta;
            }
            else if(remuneracao_bruta >= 1903.99 && remuneracao_bruta <= 2826.65)
            { 
                remuneracao_liquida = remuneracao_bruta - (remuneracao_bruta * (7.5 / 100));
            }
            else if(remuneracao_bruta >= 2826.66 && remuneracao_bruta <= 3751.05)
            { 
                remuneracao_liquida = remuneracao_bruta - (remuneracao_bruta * (15 / 100));
            }
            else if(remuneracao_bruta >= 3751.06 && remuneracao_bruta <= 4664.68)
            { 
                remuneracao_liquida = remuneracao_bruta - (remuneracao_bruta * (22.5 / 100));
            }
            else if(remuneracao_bruta > 4664.68)
            { 
                remuneracao_liquida = remuneracao_bruta - (remuneracao_bruta * (27.5 / 100));
            }

            var saida = $"olá, {nome}. você é um {ocupacao} de {idade} anos, e sua remuneração é {remuneracao_liquida}";

            Console.WriteLine(saida);
        }
    }
}
