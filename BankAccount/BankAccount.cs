using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    internal class BankAccount
    {
        public long Codigo { get; set; }
        public string NomeDoProprietario { get; set; }
        public double SaldoContido { get; set; }

        public void Deposito(double valorDeposito)
        {
            SaldoContido = valorDeposito + SaldoContido;
            Console.WriteLine("Deposito realizado!, saldo da conta agora é: ",SaldoContido);
        }
        public void Saque(double valorSaque)
        {
            if(valorSaque < SaldoContido)
            {
                SaldoContido = SaldoContido - valorSaque;
                Console.WriteLine("Saque realizado!, saldo da conta agora é: ", SaldoContido);

            }
            else
            {
                Console.WriteLine("não foi possivel realizar o saque! ");
            }
        }

        public BankAccount (long codigo, string nomeDoProprietario, double saldoContido)
        {

            if (saldoContido > 0)
            {
                Codigo = codigo;
                NomeDoProprietario = nomeDoProprietario;
                SaldoContido = saldoContido;
            }
        }
    }
}
