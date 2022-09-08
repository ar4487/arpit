using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ConsoleApp7
{
    class Class7
    {
        public static void Main64()
        {
            ArrayList al = new ArrayList();
            string str = "arpit";
            int x = 1;
            DateTime d = DateTime.Now;
            al.Add(str);
            al.Add(x);
            al.Add(d);
            foreach(var item in al)
            {
                Console.WriteLine(item);
            }
        }
    }
}