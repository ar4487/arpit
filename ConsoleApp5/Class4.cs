using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Class4
    {
        public static void Main()
        {
            int i, j,n;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        break;
                }
                if (i == j)
                    Console.WriteLine("prime numbers are" + n);
            }

        }
    }
}
