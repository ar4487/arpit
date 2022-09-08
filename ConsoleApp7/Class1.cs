using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    static class A
    {
        public static int a;
        public static void print()
        {
            Console.WriteLine(a);
        }
    }
    class B
    {
        public static int a;
        public int b;
        static B()
        {

            a = 2;
            Console.WriteLine("hi i,m from static");
        }
        public B()
        {
            b = 1;
            a = 2;
            Console.WriteLine("hi i'm from default constructor");
        }




        class Class1
        {
            public static void Main2()
            {
                B b = new B();
            }
        }
    }
}
    
    

