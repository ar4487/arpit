using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            int c = b%2 ;
            Console.WriteLine(c);
            if (a > 7)
            {
                Console.WriteLine("a is greater than 7");
            }
            else
            {
                Console.WriteLine("7 is greater than a");
            }
            Console.WriteLine("please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("value entered by you is " + name);
        }
    }
}
