using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class MyException : Exception 
    {
        public MyException (string Message):base(Message)
        {

        }
    }

    class Class11
    {
        static void Validate(int age)
        {
            if (age < 18)
            {
                throw new MyException("please enter age greater than 18");
            }
        }
        public static void Main123()
            
        {
            try
            {
                Validate(13);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
