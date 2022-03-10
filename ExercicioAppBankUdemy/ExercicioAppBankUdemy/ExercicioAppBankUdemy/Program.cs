using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ExercicioAppBankUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalContas = 0;
            while (TotalContas < 2)
            {
                ContaBancaria conta;
                Console.Write("\nEntre o numero da Conta: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Entre com o nome do titular da conta: ");
                string titular = Console.ReadLine();
                Console.Write("Havera deposito inicial (s/n) ? ");
                char pergunta = char.Parse(Console.ReadLine());
                if (pergunta == 'S' || pergunta == 's')
                {
                    Console.Write("\nEntre o valor do deposito inicial: R$");
                    double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta = new ContaBancaria(numero, titular, valorInicial);
                }
                else
                {
                    conta = new ContaBancaria(numero, titular);
                }
                Console.WriteLine(conta);
                Console.Write("\nEntre com um valor para deposito: R$");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Deposito(valor);
                Console.WriteLine(conta);
                Console.Write("\nEntre com um valor para saque: R$");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Saque(valor);
                Console.WriteLine(conta);
                TotalContas++;
            }
        }
    }
}
