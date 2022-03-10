using System;
using System.Globalization;

namespace Sessao5
{
    class Calculadora
    {
        public static double Iof = 6.00;
        public static double Calculo(double cota, double qtd)
        {

            double Total = cota * qtd;
            double Porcen = Total * Iof / 100.00;
            return Total + Porcen;
        }
    }
}
