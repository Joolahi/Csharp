using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace T9_Vehicle
{

    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int Tires { get; set; }
        public Vehicle(string brand, string model, int speed, int tires)
        {
            Brand = brand;
            Model = model;
            Speed = speed;
            Tires = tires;
        }
        public string ShowInfo()
        {
            return $"Brand: {Brand}\nModel: {Model}";
        }
        public override string ToString()
        {
            return $"Brand: {Brand}\nModel: {Model}\nSpeed: {Speed}\nTires: {Tires}";

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Vehicle moped = new Vehicle("Honda", "Monkey", 46, 2);
                Vehicle car = new Vehicle("Audi", "A4", 180, 4);
              
                Console.WriteLine(moped.ShowInfo());

                moped.Brand = "Tunturi";
                moped.Model = "Pappa";
                Console.WriteLine(moped.ToString());

              
                Console.WriteLine(car.ShowInfo());
                car.Model = "A3";
                car.Speed = 162;
                Console.WriteLine(car.ToString());
            }

        }


    }   
}

