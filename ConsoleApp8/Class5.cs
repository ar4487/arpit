using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Class5
    {
        public static void Main16()
        {
            int n, flag=0, i;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= n / 2; i++)
            {if(n % i== 0)
                
                {
                    Console.Write("number is not prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is prime");
        }
    }
}
