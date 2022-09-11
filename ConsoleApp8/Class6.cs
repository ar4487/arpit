using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Class6
    {
        public static void Main1234567()
        {
            int i, fact = 1,number;
            Console.WriteLine("Enter any number");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of "+number+ "is:"+fact);
        }
    }
}
