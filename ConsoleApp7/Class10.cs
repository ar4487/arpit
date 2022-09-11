using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Class10
    {
        static void Main34(string[] args)
        {
            int a = 7, b = 0;
            int c;
            int[] a1 = new int[3];
            try
            {
                c = 89;

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("some error occured");
                Console.WriteLine(ex.Message);

            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("some error occured");
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Hii i'm from finally block");
            }
        }
    }
}
