using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T16_Vehicle 
{ 
    class Vehicle 
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Color { get; set; }

        public Vehicle(string name, string model, int modelYear, string color)
        {
            Name = name;
            Model = model;
            ModelYear = modelYear;
            Color = color;
        }

        public virtual void PrintInfos()
        {
            Console.Write(" Name: " + Name);
            Console.Write(" Model: " + Model);
            Console.Write(" ModelYear: " + ModelYear);
            Console.Write(" Color: " + Color);

        }

    }

    class Bike : Vehicle 
    {
        public bool GearWheels { get; set; }
        public string GearName { get; set; }

        public Bike (string name, string model, int modelYear, string color, bool gearWheels, string gearName)
            : base(name, model, modelYear, color){
            GearWheels = gearWheels;
            GearName = gearName;
        }
        public override void PrintInfos()
        {
            base.PrintInfos();
            Console.Write(" GearWheels: " + GearWheels);
            Console.Write(" GearName: " + GearName);
        }

    }
    class Boat : Vehicle 
    {
        public int SeatCount { get; set; }
        public string BoatType { get; set; }

        public Boat (string name, string model, int modelYear, string color, int seatCount, string boatType)
            : base(name, model, modelYear, color) 
        {
            SeatCount = seatCount;
            BoatType = boatType;
        }
        public override void PrintInfos()
        {
            base.PrintInfos();
            Console.Write(" SeatCount: " + SeatCount);
            Console.Write(" BoatType: " + BoatType);
        }
    }

    
    

    internal class Program
    {
        static void Main(string[] args)
        {
            var Bike1 = new Bike("Jopo", "Street", 2016, "Blue", false, "");
            var Bike2 = new Bike("Tunturi", "StreetPower", 2010, "Black", true, "Shimano Nexus");
            var Boat1 = new Boat("SummerFun", "S900", 1990, "White", 3 , "Rowboat");
            var Boat2 = new Boat("Yamaha", "Model 1000", 2010, "Yellow", 5, "Motorbat");

            Console.WriteLine("Bike 1 Info:");
            Bike1.PrintInfos();
            Console.WriteLine();

            Console.WriteLine("Bike 2 Info:");
            Bike2.PrintInfos();
            Console.WriteLine();

            Console.WriteLine("Boat 1 Info:");
            Boat1.PrintInfos();
            Console.WriteLine();

            Console.WriteLine("Boat 2 Info:");
            Boat2.PrintInfos();
            Console.WriteLine();

        }
    }
}
