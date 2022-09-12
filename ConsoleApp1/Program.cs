internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Qual é o seu nome?");
        var nome = Console.ReadLine();
        Console.WriteLine("Qual sua idade?");
        var idade = Console.ReadLine();
        Console.WriteLine("Qual sua ocupação?");
        var ocupação = Console.ReadLine();
        Console.WriteLine("Qual sua remuneração bruta?");
        string? v = Console.ReadLine();
        var remuneração_bruta = v;

        var saida = $"olá, {nome}. você é um {ocupação} de {idade} anos, e sua remuneração é {remuneração_bruta}";

        Console.WriteLine(saida);

    }
}