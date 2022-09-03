using System;

namespace ConsoleApp1
{
    class SwitchCase
    {
        static void Main2(string[] args) { 
        
        Console.WriteLine("enter a day");
        String day = Console.ReadLine();
            switch (day)
            {
                case "monday" :
                case "tuesday" :
                case "wednesday" :
                case "thrusday":
                case "friday":
                    Console.WriteLine("it's working day");
                    break;
                case "saturday":
                case "sunday":
                    Console.WriteLine("it's holiday");
                    break;
                default:
                    Console.WriteLine("plz enter correct date:");
                    break;
 

            }
            }
}
}