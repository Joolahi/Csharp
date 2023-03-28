using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T15_Employee
{
    class Employee
    {
        public string name { get; set; }
        public string profession { get; set; }
        public double salary { get; set; }
    }
    class Boss : Employee
    {
        public string car
        {
        get; set;
        }
        public double bonus { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.name = "Tuomas Saha";
            employee.profession = "Blacksmith";
            employee.salary= 1500;

            Boss boss = new Boss();
            boss.name = "Suvi Virta";
            boss.profession = "Project manager";
            boss.salary = 2590;
            boss.car = "BMW";
            boss.bonus = 800;

            Console.WriteLine("Employee: ");
            Console.WriteLine($"-Name:{employee.name} Profession:{employee.profession} Salary:{employee.salary} ");
            Console.WriteLine("Boss: ");
            Console.WriteLine($"-Name:{boss.name} Profession:{boss.profession} Salary:{boss.salary} Car:{boss.car} Bonus:{boss.bonus} ");
            employee.salary = 2000;
            employee.profession = "Project Leader";
            Console.WriteLine("Employee: ");
            Console.WriteLine($"-Name:{employee.name} Profession:{employee.profession} Salary:{employee.salary} ");




        }
    }
}
