using System;

namespace myCompiler
{
    class FinalTotal
    {
        public static void Main(string[] args)
        {
            int total=10;

            Console.Write("Enter an Integer: ");
            int integ =int.Parse(Console.ReadLine());
            
            if(integ>0)
            {
                if(integ%2==0)
                {
                    Console.WriteLine("The number is even.");
                    integ=(integ*integ);
                    total+=integ;
                    Console.WriteLine(total);
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                    integ=(integ*integ*integ);
                    total+=integ;
                    Console.WriteLine(total);
                }
            }
            else if(integ<0)
            {
                Console.Write("Enter another Integer: ");
                int exp =int.Parse(Console.ReadLine());

                for(int i=0;i<exp;i++)
                {
                    integ*=integ;
                }
                total+=integ;
                Console.WriteLine(total);
            }
            else
            {
                Console.Write("Nothing happened.");
            }
        }
    }
}
