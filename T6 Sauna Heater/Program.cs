using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace T6_Sauna_heater
{
    public class Heater
    {
        private int temperature = 0;
        private int humidity = 0;
        private bool status = false;
        public void setOn()
        {
             status = true;
        }
        public void setOff()
        {
           status = false;
        }
        public int Temperature 
        { 
            get { return temperature; }
            set {temperature = value; }
        }
        public int Humidity 
        {
            get { return humidity; }
            set {humidity = value;} 
        }

        public bool Status 
        {
            get { return status; }
        }
    }
    
    
   
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Heater heater = new Heater();

            Console.WriteLine($"Heater is: {heater.Status}");

            heater.Temperature = 89;
            heater.Humidity = 38;
            heater.setOn();

            Console.WriteLine($"Heater is now: {heater.Status}");
            Console.WriteLine($"Tempereature is: {heater.Temperature} degrees celsius");
            Console.WriteLine($"Humidity in sauna is: {heater.Humidity} %");

            heater.setOff();
            Console.WriteLine($"Heater is now: {heater.Status} \n Sauna was great!");

           
        }

    }
    
    
}



