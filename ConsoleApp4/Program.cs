using System;

namespace ConsoleApp4
{
    class Program 
    
    {
         public static void swap(int num1,int num2)
        {
            int newnum;
            newnum = num1;
            num1 = num2;
            num2 = newnum;
            Console.WriteLine("\n value after swapping num1 = " +num1+"\n num2="+num2);
        }
        public static void Main()
        {
            int num1,num2;
            Console.WriteLine("Enter 1 number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2 number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nvalue before swapping num1= "+num1+"\n num2 = "+num2);

            swap(num1, num2);
            
        }
    }
}
