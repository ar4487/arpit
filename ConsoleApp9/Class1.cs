using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace helloworld
{
    class LinqExercise8
    {
        static void Main(string[] args)
        {
            string chst = "N";
            string chen = "I";


            string[] cities = new string[4];
            for (int i = 0; i < 4; i++)
            {
                cities[i] = Console.ReadLine();
            }


            var _result = from x in cities
                          where x.StartsWith(chst)
                          where x.EndsWith(chen)
                          select x;
            Console.Write("\n\n");
            foreach (var city in _result)
            {
                Console.Write(city);
            }

            Console.ReadLine();
        }
    }

}