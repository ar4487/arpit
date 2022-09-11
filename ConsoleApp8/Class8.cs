using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Class8
    {
        public static void Mai12345()
        {
            String[] cars = new string[10];
            Console.WriteLine("Enter number of car you want to Enter:");
            int num = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter cars name :");
            for(int i = 0; i < num; i++)
            {
                cars[i] = Console.ReadLine(); 
            }
            Console.WriteLine("Sorted list:");
            Array.Sort(cars);
            foreach (string i in cars)
                
            {
                Console.WriteLine(i);
            }
        }
    }
}
