using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main3(string[] args)
        {
            int i;
            Console.WriteLine("Enter a number");
            i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("number is even");
                
            }
            else
            {
                Console.WriteLine("number is odd");
            }
        }

    }
}
