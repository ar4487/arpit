using System;

namespace VehicleApp
{

    // Code here ...
    abstract class MotorVehicle
    {
        public abstract string DriveVehicle();
        public  string DriveStatus { get; private set; }
    }
    class TwoWheeler : MotorVehicle
    {
        public override string DriveVehicle()
        {
            
            return "You are driving two wheeler";
            }
        }
        class FourWheeler : MotorVehicle
        {
            public override string DriveVehicle()
            {
               
                return "You are driving four wheeler";
                }
            }
            class Source
            {
                static void Main(string[] args)
                {
                    // code here ...
                    var twoWheeler = new TwoWheeler();
                    Console.WriteLine($"{twoWheeler.DriveStatus}");
                    var twoWheelerDrive = twoWheeler.DriveVehicle();
                    Console.WriteLine($"{twoWheelerDrive}");
                    var fourWheeler = new FourWheeler();
                    Console.WriteLine($"{fourWheeler.DriveStatus}");
                    var fourWheelerDrive = fourWheeler.DriveVehicle();
                    Console.WriteLine($"{fourWheelerDrive}");
                }
            }
        }