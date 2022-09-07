using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class calculator
    {
        int n1, n2;
        public calculator(int num1,int num2)
        {
            n1 = num1;
            n2 = num2;
        }
        public void print()
        {
            Console.WriteLine("number 1="+n1);
            Console.WriteLine("number 2=" + n2);
        }
        public static calculator operator+(calculator c1, calculator c2)
        {
            calculator c3 = new calculator(10, 10);
            c3.n1 = c1.n1 + c2.n1;
            c3.n2 = c1.n2 + c2.n2;
            return c3;
        }
    }
    class Class14
    {
        public static void Main()
        {
            calculator c1 = new calculator(30,40);
            calculator c2 = new calculator(20,20);
            calculator c3 = new calculator(10, 10);
            c3 = c1 + c2;
            c3.print();

        }
    }
}
