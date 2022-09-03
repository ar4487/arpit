using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("enter your age:");
           age= Convert.ToInt32(Console.ReadLine());
     if (age >=60)
            {
                Console.WriteLine("you are senior and eligible to vote");
            }
     else if (age >=18) 
            {
                Console.WriteLine("you are eligible to vote");
            }
            else
            {
                Console.WriteLine("you are not elegible to vote");
            }
        }
    }
}
