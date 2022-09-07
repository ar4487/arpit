using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Class6
    {
        public static void Main10()
        {
            string string1, rev=string.Empty;
            Console.WriteLine("enter string");
            string1 = Console.ReadLine();
            if(string1 != null)
            {
                for(int i= string1.Length -1; i >= 0; i--)
                {
                    rev += string1[i].ToString();
                }
                if (rev == string1)
                {
                    Console.WriteLine("string is palindrome input= {0} and output ={1} ",string1,rev);
                }
                else
                {
                    Console.WriteLine("string is not palindrome input= {0} and output ={1} ", string1, rev);
                }
            }
        }
    }
}
