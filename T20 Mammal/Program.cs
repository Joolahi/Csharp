using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T20_Mammal
{
    public abstract class Mammal
    {
        public int Age { get; set; }
        public abstract void Move();
    }
    public class Human : Mammal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public override void Move()
        {
            Console.WriteLine("Moving");
        }
        public void Grow()
        {
            Age++;
        }
    }
    public class Baby: Human
    {
        public string Diaper { get; set; }
        public override void Move() 
        {
            Console.WriteLine("Crawling");
        }
    }
    public class Adult: Human 
    {
        public string Auto { get; set; }
        public override void Move() 
        {
            Console.WriteLine("Walking");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var baby = new Baby
            {
                Name = "Sinikka",
                Age= 2,
                Weight = 9,
                Height = 0.7,
                Diaper = "Libero"
            };
            var adult1 = new Adult
            {
                Name = "Topi",
                Age = 29,
                Weight = 95,
                Height = 185,
                Auto = "Audi"

            };
            var adult2 = new Adult
            {
                Name = "Leena",
                Age = 68,
                Weight = 65,
                Height = 161,
                Auto = "BMW"
            };

            baby.Move();
            adult1.Move();

            Console.WriteLine($"Baby: {baby.Name} Age: {baby.Age} Weight: {baby.Weight} kg Height: {baby.Height} Diapers: {baby.Diaper} ");
            Console.WriteLine($"Adult: {adult1.Name} Age: {adult1.Age} Weight: {adult1.Weight} kg Height: {adult1.Height} Auto: {adult1.Auto}");
            Console.WriteLine($"Adult: {adult2.Name} Age: {adult2.Age} Weight: {adult2.Weight} kg Height: {adult2.Height} Auto: {adult2.Auto}");

            baby.Grow();
            adult2.Grow();

            Console.WriteLine($"Baby: {baby.Name} Age: {baby.Age} Weight: {baby.Weight} kg Height: {baby.Height} Diapers: {baby.Diaper} ");
            Console.WriteLine($"Adult: {adult1.Name} Age: {adult1.Age} Weight: {adult1.Weight} kg Height: {adult1.Height} Auto: {adult1.Auto}");
            Console.WriteLine($"Adult: {adult2.Name} Age: {adult2.Age} Weight: {adult2.Weight} kg Height: {adult2.Height} Auto: {adult2.Auto}");



        }
    }
}
