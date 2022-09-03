using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Class3
    {
        static void Main2(String[] args)
        {
            Console.WriteLine("calculator");
            Console.WriteLine("........");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("Enter choice(1-4)");
            int ch = Convert.ToInt32(Console.ReadLine());
            int a, b, c;
            switch (ch)
            {
                case 1:
                    Console.WriteLine("enter A");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter b");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine("sum ="+c);
                    break;
                case 2:
                    Console.WriteLine("enter A");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter b");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a - b;
                    Console.
                    break;
                case 3:
                    Console.WriteLine("enter A");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter b");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a * b;
                    break;
                case 4:
                    Console.WriteLine("enter A");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter b");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a / b;
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }

        }
    }
}
