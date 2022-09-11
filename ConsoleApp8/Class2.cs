using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Class2
    {
        public static void Main12637()
        {
            int n, rem,reverse=0,temp;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n =n/ 10;
            }
            Console.WriteLine("Reversed number:" + reverse);

            if (temp == reverse)
            {
                Console.Write("Number is palindrome");
            }
            else
            {
                Console.Write("Number is not palindrome");
            }
        }
    }
}
