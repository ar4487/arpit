using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Class3
    {
        public static void Main5()
        {
            int n, fact = 1, i;
            Console.WriteLine("Enter any number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
                fact = fact * i;
            {
                Console.WriteLine("factorial of" + n +" is:"+fact);
            }
        }
    }
}
