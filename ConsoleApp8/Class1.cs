using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{

    class Class1
    {
        static int maxCHAR = 256;
        static void calculate(string s, int[] cal)
        {
            for (int i = 0; i < s.Length; i++)
                cal[s[i]]++;
        }

        public static void Main22233()
        {
            Console.WriteLine("Enter String");
            String s = Console.ReadLine();
            int[] cal = new int[maxCHAR];
            calculate(s, cal);
            for (int i = 0; i < maxCHAR; i++)
            {
                if (cal[i] > 1)
                {
                    i = i + (cal[i] > 0);

                  
                }
               

            }

            Console.ReadLine();
        }

    }
}