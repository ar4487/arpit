using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Class3
    {
        public static void Main5215()
        {
            String str="",reverse="" ;
            int Length = 0;
            Console.WriteLine("Enter a word");
            str = Console.ReadLine();
            Length = str.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }
            Console.WriteLine("reverse Word is{0}", reverse);
            Console.ReadLine();
        }
    }
}
