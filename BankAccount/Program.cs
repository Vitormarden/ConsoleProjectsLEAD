using System;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount conta = new BankAccount(6584,"vitor",100);
            Console.WriteLine(conta.NomeDoProprietario);

            Client client = new Client("vitor", "estudante", "09/09/2002", "vitomarden1234@gmail.com");
            client.InformancoesCliente();
            client.IdadeCliente();

        }

    }
}
