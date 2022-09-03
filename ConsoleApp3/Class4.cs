using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Class4
    {
        static void swap( int num1, int num2)
        {
            int newnum;

            newnum = num1;
            num1 = num2;
            num2 = newnum;
            }
        public static void Main1(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter num1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            n2 = Convert.ToInt32(Console.ReadLine());
            swap( n1,n2);
            Console.WriteLine("after swapping num1="+n2,"num2 ="+n1);
        }
    }
}
