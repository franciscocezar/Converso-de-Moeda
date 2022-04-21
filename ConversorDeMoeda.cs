using System;
namespace ProjetoCotação
{
    public class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double Conversor(double dolar, double cotacao)
        {
            double total = dolar * cotacao;
            return total + total * Iof / 100.0;
        }
    }
}
