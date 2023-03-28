using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24_Vehicle
{
    class Tire
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string TireSize { get; set; }
    }

    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public List<Tire> Tires { get; set; }

        public Vehicle(string name, string model)
        {
            Name = name;
            Model = model;
            Tires = new List<Tire>();
        }

        public void AddTire(Tire tire)
        {
            Tires.Add(tire);
        }

        public void PrintTires()
        {
            Console.WriteLine("Vehicle Name: {0} Model: {1} has tires:", Name, Model);
            foreach (Tire tire in Tires)
            {
                Console.WriteLine("-Name: {0} Model: {1} TireSize: {2}", tire.Manufacturer, tire.Model, tire.TireSize);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Car and tires
            Vehicle car = new Vehicle("Porsche", "911");
            Tire carTire = new Tire() { Manufacturer = "Nokia", Model = "Hakkapeliitta", TireSize = "205R16" };
            car.AddTire(carTire);
            car.AddTire(carTire);
            car.AddTire(carTire);
            car.AddTire(carTire);
            Console.WriteLine("Created a new vehicle {0} model {1}", car.Name, car.Model);
            foreach (Tire tire in car.Tires)
            {
                Console.WriteLine("Tire {0} added to vehicle {1}", tire.Manufacturer, car.Name);
            }
            car.PrintTires();

            // Motorcycle and tires
            Vehicle motorcycle = new Vehicle("Ducati", "Diavel");
            Tire motorcycleTire1 = new Tire() { Manufacturer = "MIC", Model = "Pilot", TireSize = "160R17" };
            Tire motorcycleTire2 = new Tire() { Manufacturer = "MIC", Model = "Pilot", TireSize = "140R16" };
            motorcycle.AddTire(motorcycleTire1);
            motorcycle.AddTire(motorcycleTire2);
            Console.WriteLine("Created a new vehicle {0} model {1}", motorcycle.Name, motorcycle.Model);
            foreach (Tire tire in motorcycle.Tires)
            {
                Console.WriteLine("Tire {0} added to vehicle {1}", tire.Manufacturer, motorcycle.Name);
            }
            motorcycle.PrintTires();
            Console.ReadLine();
        }
    }
}
