﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{ 
    abstract class Animal
    {
        public string name;
        public void getname()
        {
            Console.WriteLine("Enter a name of dog");
        }
        public void setname()
        {
            name = Console.ReadLine();
        }
        abstract public void eat();
    }
    class Dog : Animal
    {
        override public void eat()
        {
            Console.WriteLine(name + " is eating");
        }
     
   }
    class classdog
    {
        public static void Main13()
        {
            Dog d1 = new Dog();
            d1.getname();
            d1.setname();
                d1.eat();
        }
    }
}
