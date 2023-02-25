using System;
using System.Globalization;

namespace ConversorDeMoeda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a cotação do dólar?");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar?");
            double quantidadeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CalculoDolar.CalcularDolar(cotacaoDolar, quantidadeDolar);

            Console.WriteLine("Valor a ser pago em reais:" + CalculoDolar.CalcularDolar(cotacaoDolar, quantidadeDolar).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}