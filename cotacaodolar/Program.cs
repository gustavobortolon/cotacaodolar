using System;
using System.Globalization;

namespace cotacaodolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Qual a cotacao do dolar:");
            double dolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Console.WriteLine("Quantos dolares voce vai comprar:");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double result = Cotacao.DolarParaReal(dolar, quantidade);
            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
