using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main3(string[] args)
        {
            int n,i,flag = 0;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
         
            for (i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("number is not prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("number is prime");

            
        }
    }
}
