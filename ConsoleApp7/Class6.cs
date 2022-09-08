using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class indexerClass
    {
        private string[] name = new string[3];
        public string this[int i]
        {
            get
            {
                return name[i];
            }
            set
            {
                name[i] = value;

            }
        }
    }
    class Class6
    {
        public static void Main121()
        {
            indexerClass c = new indexerClass();
            c[0] = "vikash";
            c[1] = "arpit";
            c[2] = "raj";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }
}
