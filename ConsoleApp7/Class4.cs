using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    struct Employee
    {
        int employee_id;
        string employee_name;
        public void Getdata()
        {
            Console.WriteLine("please enter id");
            employee_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter name");
            employee_name = Console.ReadLine();
        }
        public void print()
        {
            Console.WriteLine("Employee details are:");
            Console.WriteLine("employee_id : {0}  employee_name : {1}",employee_id,employee_name);
        }
    }
    class Class4
    {
        public static void Main23()
        {
            Employee e = new Employee();
            e.Getdata();
            e.print();
        }
    }
}
