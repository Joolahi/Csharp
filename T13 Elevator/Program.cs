using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace T13_Elevator
{
    class Elevator
    {
        private int floor = 1;
        public int Floor
        {
            get { return floor; }
        }


        public bool GoTo(out string message)
        {
            message = "";
            Console.Write("Give a new floor number (1-5) > ");
            string input = Console.ReadLine();
            int currentFloor;
            if (!int.TryParse(input, out currentFloor))
            {
                message = "Input is not valid." ;
                return false;
            }
            if (currentFloor < 1) 
            {
                message = "Floor is too small." ;
                return false;
            }
            if(currentFloor > 5)
            {
                message = "Floor is too big."  ;
                return false; 
            }
            floor = currentFloor;
            message = $"Elevator is now in floor {floor}";
            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            while (true)
            {
                string message;
                string failedMessage;
                bool success = elevator.GoTo(out message);
                if (success) 
                {
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine(message);
                }
            }
               
        }
    }
    
}

