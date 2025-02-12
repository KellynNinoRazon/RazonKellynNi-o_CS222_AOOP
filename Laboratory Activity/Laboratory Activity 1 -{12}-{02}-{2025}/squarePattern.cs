using System;

class Program
{
    public static void Main(string[] args)
    {
       Console.Write("Enter n: ");
       int mark = int.Parse(Console.ReadLine());
       Console.Write("Enter y: ");
       int skip = int.Parse(Console.ReadLine());
       
       for(int runs=1;runs<=mark;runs++)
       {
           if (runs!=skip)
           {
               for(int ast=0;ast<mark;ast++)
               Console.Write("*");
           }
           Console.Write("\n");
       }
    }
}
