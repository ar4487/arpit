using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp8
{
    class Program
    {
        static void Main12345(string[] args)
        {
            String txt;
            Console.WriteLine("Enter String: ");
            txt = Console.ReadLine();
            Console.WriteLine("\nThe length of String "+txt.Length);
            Console.WriteLine("\nString: "+txt);
           while(txt.Length > 0)
            {
                Console.Write(txt[0] + " = ");
                int j = 0;
                for (int i = 0; i < txt.Length; i++)
                {
                    if (txt[0] == txt[i])
                    {
                        j++;
                    }
                }
                Console.WriteLine(j);
                txt = txt.Replace(txt[0].ToString(),String.Empty);
            }
            Console.ReadLine();
        }
    }
}
