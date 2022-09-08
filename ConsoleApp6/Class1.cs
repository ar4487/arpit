using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Person
    {
        protected string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "Hello my name is " + Name;
        }
        ~Person()
        {
            Name = string.Empty;
        }
    
    public class Teacher : Person
        {
            public Teacher(string name) : base(name)
            {
                Name = name;
            }
            public void Explain()
            {
                Console.WriteLine("teacher is explaing");
            }
        }

        public class Student : Person
        {
            public Student(string name): base(name)
            {
                Name = name;
            }
            public void study()
            {
                Console.WriteLine("Studying");
            }
        }

    }
   public class Class1
    {
        public static void Main21()
        {
            int total = 3;
            Person[] persons = new Person[total];
            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    persons[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    persons[i] = new Student(Console.ReadLine());
                }
            }
            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    ((Teacher)persons[i]).Expalin();
                }
                else
                {
                    ((Student)persons[i]).Study();
                }
            }
        }

            
        
    

