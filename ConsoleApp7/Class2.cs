using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    struct students
    {
        public int student_id;
        public string student_name;
    }
    class Class2
    {
        public static void Main5()
        {
            students s;

            Console.WriteLine("Enter your id");
            s.student_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name");
            s.student_name = Console.ReadLine();
            Console.WriteLine("student id is {0}  student name is {1}",s.student_id,s.student_name);
        }
    }
}
