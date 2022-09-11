using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ConsoleApp7
{
    public class Employee1
    {
        public int Id { get; set; }
        
        public String Name { get; set; }
        public String Gender { get; set; }
        public int Salary { get; set; }


    }
    class Class13
    {
        public static void Main()
        {
            Console.WriteLine("Please enter your choice you want to do \n 1.Add \n 2.Delete");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("please Enter details to Add:\nEmployee_Id,\nEmployee_name\nEmployee_Gender\nEmployee_salary");
                    Console.ReadLine();


                    break;

                    

            }
        }
    }
}
   