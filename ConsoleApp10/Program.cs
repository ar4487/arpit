using System;

namespace ConsoleApp10
{
    class counter
    {
        int[] data = new int[4];
        public counter(int[] data)
        {
            this.data = data;

           }
        public string GetCount()
        {

        }
    }
class Program
    {
       
        static void Main(string[] args)
        {

            int[] data = new int[4];
            for (int i = 0; i <= 4; i++)
                {
                    data[i] = Convert.ToInt32(Console.ReadLine());
            }
        
    }
    }
    }

