using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    abstract class abc
    {
        abstract public void print();
        public void show()
        {
            Console.WriteLine("asbad");
        }
    }
    class Abc2 : abc
    {
        int a = 1;
        int b = 2;
        public override void print()
        {
            Console.WriteLine("i am print");
        }
        public override string ToString()
        {
            return "a= " + a + "b= " + b;
        }
        }

    class Class7
    {
        public static void Main9()
        {
            Abc2 abc = new Abc2();
            string sampl = abc.ToString();
            Console.WriteLine(sampl);

        }

    }
}
