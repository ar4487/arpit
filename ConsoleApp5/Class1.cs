using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Class1
    {
        public static void Main2()
        {
            int num1 = 0, num2 = 1, num3, i, number;
            Console.WriteLine("Enter number of elements");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(num1+"\n" + num2 + "");
            for (i = 2; i <=number; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3+"");
                num1 = num2;
                num2 = num3;

            }
        }
    }
}