using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
   
    class Class2
    {
        public static void Main3()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Enter doctor details");
            Console.WriteLine("(1) Registration no");
            Console.WriteLine("(2) Doctor name ");
            Console.WriteLine("(3) City");
            Console.WriteLine("(4) Area of Specialization");
            Console.WriteLine("(5) Clinic adress");
            Console.WriteLine("(6) clinic timing");
            Console.WriteLine("(7) Contact number");
            Console.WriteLine("(8) Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    Registrationno();
                    return true;
                case "2":
                    Doctorname();
                    return true;
                case "3":
                    City();
                    return true;
                case "4":
                    Areaofspecialization();
                    return true;
                case "5":
                    ClinicAdress();
                    return true;
                case "6":
                    Clinictimming();
                    return true;
                case "7":
                    Contactnumber();
                    return true;
                case "8":
                    return false;
                default:
                    return true;

            }
        }
        public static void Registrationno()
        {
            Console.WriteLine("Enter your registration number :");
            int no = Convert.ToInt32(Console.ReadLine());
            for (int Input= 0; no <= 7; no++)
            { 
                if (Input.Length == 7)
                {
                    Console.Write(no);
                }
                else
                {
                    Console.WriteLine("Enter registration number again");
                    Console.ReadLine();
                 }
            }
        }
        public static void Doctorname()
        {
            Console.WriteLine("Enter your doctor name: ");
            string name = Console.ReadLine();
           
                }
        public static void City()
        {
            Console.WriteLine("Enter city name: ");
            string city = Console.ReadLine();
        }
        public static void Areaofspecialization()
        {
            Console.WriteLine("Enter area of specialization: ");
        }
            }
        }

    

