using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
   
{
    abstract class animal
    {
        public abstract void dogname();
        public abstract void dogeat();
    }
    class dog : animal
    {
        public override void dogeat()
        {
            Console.WriteLine("pedigree");
        }
        public override void dogname()
        {
            Console.WriteLine("toomy");
        }
    }
    class Class8
    {
        static void Main11()
        {
            dog obj = new dog();
            obj.dogname();
            Console.ReadLine();
        }
    }
}
