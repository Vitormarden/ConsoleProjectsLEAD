internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Qual é o seu nome?");
        string nome = Console.ReadLine();
        Console.WriteLine("Qual sua idade?");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual sua ocupação?");
        string ocupação = Console.ReadLine();
        Console.WriteLine("Qual sua remuneração bruta?");

        double remuneração_bruta = double.Parse(Console.ReadLine());
       
        double remuneração_liquida = remuneração_bruta - (remuneração_bruta * (7.5 / 100));


        var saida = $"olá, {nome}. você é um {ocupação} de {idade} anos, e sua remuneração é {remuneração_liquida}";

        Console.WriteLine(saida);

    }
}