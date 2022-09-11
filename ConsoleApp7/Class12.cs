using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class sample
    {
        public sample(int a)
        {
            Console.WriteLine("hii i'm sample "+a);
        }
    }
    class sampleB : sample 
    {
        public sampleB(int a):base(a)
        {
            Console.WriteLine("Hii i;m sample B "+a);

        }

    }
    class sampleC : sampleB
    {
        public sampleC(int a) : base(a)
        {
            Console.WriteLine("Hii i'm sample C "+a);
        }
    }

    class Class12
    {
        public static void Main1234()
        {
            sampleC c = new sampleC(2);
        }
    }
}
