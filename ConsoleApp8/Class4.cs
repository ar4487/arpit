using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Class4
    {
        public static void Main14()
        {
            int num,x;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Factors are : ");
            for (x = 1; x <= num; x++)
            {
                if (num % x == 0)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
