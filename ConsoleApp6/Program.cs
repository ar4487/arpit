using System;

namespace ConsoleApp6
{
    class B
    {
        int a;
        public B(int a)
        {
            this.a = a;

        }
        public void print()
        {
            Console.WriteLine("value of a is " + a);
        }
    }
    class Program
    {
        static void Main13(string[] args)
        {
            B b = new B(1);
            b.print();
            B b1 = new B(2);
            b1.print();
        }
    }
}
