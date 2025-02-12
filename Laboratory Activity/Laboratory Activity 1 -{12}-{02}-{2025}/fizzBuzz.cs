using System;

class Program
{
    public static void Main(string[] args)
    {
       int runs=1;
       while(runs<=15)
        {
            if (runs % 3==0 && runs % 5==0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (runs % 3==0)
            {
                Console.WriteLine("Fizz");
            }
            else if (runs % 5==0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(runs);
            }
            runs++;
        
        }
    }
}
