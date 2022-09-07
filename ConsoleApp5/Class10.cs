using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{  public class class10
    {
        public static void Main13()
        {
            int total = 3;
            Person[] persons = new Person[total];
            for(int i = 0; i < total; i++)
            {
                persons[i] = new Person(Console.ReadLine());
            }
            for( int i =0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
        }
        public class Person
        {
            public string Name;
            public Person(string name)
            {
                Name = name;
            }
            public override string ToString()
            {
                return "hello my name is " + Name;
            }
          
          
                }
            }
        }
    
