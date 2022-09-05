using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Class2
    {
        public static void Main4()
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n%10;
                sum = ( sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
              Console.WriteLine("number is palindrome");
                else
                    Console.WriteLine("number is not palindrome");
            }
           
        }
    }

