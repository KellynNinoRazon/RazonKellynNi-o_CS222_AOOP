using System;

class Program
{
    public static void Main(string[] args)
    {
       Console.Write("First character: ");
       char first =char.Parse(Console.ReadLine());
       Console.Write("Second character: ");
       char second =char.Parse(Console.ReadLine());
       Console.Write("Enter size: ");
       int size = int.Parse(Console.ReadLine());

       for(int runs=1;runs<=size;runs++)
       {
           for(int dash=0;dash<runs;dash++)
           {
               Console.Write("-");
           }
           if (runs % 2!=0 )
           {
                Console.Write(first);
           }
           else
           {
               Console.Write(second);
           }
           Console.Write("\n");
       }
    }
}
