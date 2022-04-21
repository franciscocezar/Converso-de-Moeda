using System;

namespace ProjetoCotação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cot = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            double dolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em reais = "
                + ConversorDeMoeda.Conversor(dolar, cot).ToString("F2"));


        }
    }
}
