using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace T7_Water_Machine
{
    public class WashingMachine
    {
        public int waterTemperature = 0;
        public int machineSpeed = 0; 
        private bool power = false;
      

        public void powerOff()
        {
            power = false;
        }
        public void powerOn()
        {
            power = true;
        }
        public bool Power
        {
            get { return power; }
        }
        public int Speed
        {
            get{ return machineSpeed; }
            set { machineSpeed = value; }
        }  
        public int Temperature
        {
            get { return waterTemperature; }
            set { waterTemperature = value; }
        }
   



    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Set power on by writing start: ");
            string power = Console.ReadLine();
            if (power == "start")
            {
                WashingMachine machine = new WashingMachine();
                machine.powerOn();
                Console.WriteLine($"Washing Machine power is now: {machine.Power} ");
                Console.Write("Give a water temperature: ");
                int temp = Int32.Parse(Console.ReadLine());
                machine.Temperature = temp;
                Console.WriteLine($"Water temperature is set on: {machine.Temperature} degrees celcius.");
                Console.Write("Set spinning speed: ");
                int spinning = Int32.Parse(Console.ReadLine());
                machine.Speed = spinning;
                Console.WriteLine($"Machine spinning speed is set on: {machine.Speed} rounds per minute.");
                machine.powerOff();
                Console.WriteLine($"Washing machine is ready and power is now: {machine.Power}");

            }
            else
            {
              
                Console.WriteLine($"Machine is not activated");
            }
            

        }
    }
}