using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace T5_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Data> names= new List<Data>();
            Console.WriteLine("Please, give names and birth year of a person. Empty input will stop the input.");
            while (true)
            {
                Console.Write("Give a name: ");
                string data = Console.ReadLine();

                if (data == string.Empty)
                {
                    break;
                }

                string[] seperator = data.Split(',');

                string name = seperator[0].Trim();
                int year = Int32.Parse(seperator[1].Trim());
                int age = 2023 - year;


                names.Add(new Data { Name = name, Age = age });

            }

            Console.WriteLine($"{names.Count} names are given:");
            names.Sort((min,max) => min.Age.CompareTo(max.Age));
            foreach (Data people in names)
            {
                Console.WriteLine(people.ToString());
            }
        }
    }

    struct Data
    {
        public string Name;
        public int Age;

        public override string ToString()

        {
            return ($"{Name} is  {Age} years old.");
        }
    }
}

