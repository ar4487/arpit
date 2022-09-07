using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Person
    {
        public int age;
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
        public void SetAge(int n)
        {
            age = n;
        }
    }
    public class student : Person
    {
        public void study()
        {
            Console.WriteLine("I'm studying");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is {0} years",age);
        }
    }
    public class teacher : Person
    {
        public void ShowAge()
        {
            Console.WriteLine("My age is {0} years",age);
        }
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
    class Class11
    {
        public static void Main13()
        {
            Person myperson = new Person();
            myperson.Greet();

            student mystudent = new student();
            mystudent.SetAge(21);
            mystudent.Greet();
            mystudent.ShowAge();
            mystudent.study();

            teacher myteacher = new teacher();
            myteacher.SetAge(30);
            myteacher.Greet();
            myteacher.ShowAge();
            myteacher.Explain();
        }
    }
}
