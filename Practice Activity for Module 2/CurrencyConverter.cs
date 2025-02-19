using System;

namespace myCompiler
{
    class CurrencyCalculator
    {
        public static void Main(string[] args)
        {
        Console.Write("Enter Amount in USD: ");
        double usD =double.Parse(Console.ReadLine());

        Console.Write("Enter exchange rate from USD to EUR: ");
        double rate =double.Parse(Console.ReadLine());

        double equivalent=(usD*rate);

        Console.WriteLine("Amount in EUR: {0:F2}",equivalent);
        }
    }
}
