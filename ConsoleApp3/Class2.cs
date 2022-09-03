using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Class2
    {
        static void Main(String[] args)
        {
            int i, j, n;
            Console.Write("enter numbers");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            if (i > j)
            {
                if (i > n)
                {
                    Console.WriteLine("i is largest");
                }
                else
                {
                    Console.WriteLine("n is largest");
                }
            }
            else if (j > n)
                Console.WriteLine("j is largest");
            else
                Console.WriteLine("n is largest");
            }
            }
        }
    




