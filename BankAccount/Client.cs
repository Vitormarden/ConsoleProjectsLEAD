using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    internal class Client
    {
        public string Nome { get; set; }
        public string Ocupacao { get; set; }
        public string DataDeNascimento { get; set; }
        public string Email { get; set; }

        public void InformancoesCliente()
        {
            Console.WriteLine($"{Nome} você é {Ocupacao} nasceu no dia {DataDeNascimento} e seu email é {Email}");
        }
        public void IdadeCliente( )
        {
            string[] barras = DataDeNascimento.Split("/");
            

            Console.WriteLine( 2022 - Int32.Parse(barras[2]));
        }
        public Client (string  nome, string ocupacao, string dataDeNascimento, string email)
        {
            this.Nome = nome;
            this.Ocupacao = ocupacao;
            this.DataDeNascimento = dataDeNascimento;
            this.Email = email;

        }

    }
}
