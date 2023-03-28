using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_Consumption
{
    internal class Program
    {
        public static void CountConsumption(double kilometres)
        {
       
            Random rnd = new Random();
            double litres = rnd.NextDouble() * (9 - 6) + 6;
            double euros = rnd.NextDouble() * (2.5 - 1.75) + 1.75;
            double fuelConsumption = (kilometres / 100) * litres;
            double price = fuelConsumption * euros;
            Console.WriteLine($"Fuel consumption is {Math.Round(fuelConsumption, 2)} litres and it costs {Math.Round(price, 2)} euros.");
   
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter distance traveled: ");
            double distance;
            bool success = double.TryParse(Console.ReadLine(), out distance);
            if (success)
            {
                CountConsumption(distance);
            }
            else
            {
                Console.WriteLine("Input value is not valid!");
            }

         }
    }
}
