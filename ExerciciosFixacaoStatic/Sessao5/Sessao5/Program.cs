using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Sessao5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotacao do dollar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dollares voce vai comprar? ");
            double quanti = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double total = ConversorDeMoeda.DollarParaReal(quanti, cotacao);
            Console.Write("Valor a ser pago em reais = " + total.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
            //SEGUNDO PROGRAMA --------------------------------------------
            Console.WriteLine("digite a cotacao 2: ");
            double cotacao2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("quantos dollars deseja comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double tt = Calculadora.Calculo(cotacao, quanti);
            Console.WriteLine("Total a pagar com IOF fica: " + tt.ToString("F2"));
        }
    }
}
