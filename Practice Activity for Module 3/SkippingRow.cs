using System;

namespace myCompiler
{ 
    class SkippingRow
    {
        public static void Main(string[] args)
        {
        Console.Write("Enter n: ");
        int n =int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        int y =int.Parse(Console.ReadLine());
        
        for(int runs=1;runs<=n;runs++)
        {
            if (runs==y)
            {
                cConsole.Write("\n");
            }
            else
            {
            for(int star=0;star<n;star++)
            {
                    Console.Write("*");
            }
                Console.Write("\n");
            }
            }
        }
    }
}