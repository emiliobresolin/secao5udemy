using System;
using System.Globalization;

namespace Sessao5
{
    class ConversorDeMoeda
    {
        static double Iof = 6.00;
        public static double DollarParaReal(double quanti, double cotacao)
        {
            double total = quanti * cotacao;
            return total + total * Iof / 100.00;
        }
    }
}
