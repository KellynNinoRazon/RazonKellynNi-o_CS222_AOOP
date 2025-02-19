using System;

namespace myCompiler
{
    class InterestCalculator
    {
        public static void Main(string[] args)
        {
        Console.Write("Enter Principal Amount: ");
        double principal =double.Parse(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        double rate =double.Parse(Console.ReadLine());

        Console.Write("Enter Time in Years: ");
        double year = double.Parse(Console.ReadLine());

        double interest=((principal*rate*year)/100);

        Console.WriteLine("Simple Interest: {0:F2}",interest);
        }
    }
}
