using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class MethodOverloading
    {
        public void sum(int a,int b)
        {
            Console.WriteLine(a + b);
         }
        public void sum(int a,int b,int c)
        {
            Console.WriteLine(a + b + c);
        }
        public void sum(double a,double b)
        {
            Console.WriteLine(a + b);
        }
    }
    class Class13
    {
        public static void Main14()
        {
            MethodOverloading obj = new MethodOverloading();
            obj.sum(1, 2);
            obj.sum(1, 2, 3);
            obj.sum(1.57, 2.35);
        }

    }
}
