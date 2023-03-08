using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace T8_Television
{

    public class Television
    {
        public int Channel = 0;
        public int Volume = 0;
        public bool Power = false;
        public string Input;

      
        public void PowerOn()
        {
            Power = true;
        }
        public void PowerOff() 
        {
            Power = false;
        }
        public int ChangeVolume
        {
            get { return Volume; }
            set { 
                if (Volume >= 0 && Volume <= 100)
                {
                    Volume = value;
                }
                Volume =value ; 
            }
        
        }
        public int ChangeChannel
        { get { return Channel; } 
            set { if (Channel >=0 && Volume <= 400)
                { Channel= value; }
            Channel= value ;
                    }
        }
        public string SelectInput
        {
            get { return Input; }
            set { Input = value; }
        }
     


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Television tv = new Television();
            tv.PowerOn();
            tv.ChangeVolume = 75;
            tv.ChangeChannel = 28;
            tv.SelectInput = "HDMI";
            Console.WriteLine($"Television power is: {tv.Power} \nVolume is: {tv.Volume} \nChannel is {tv.Channel} \nSelected input is {tv.SelectInput}");
            tv.PowerOff();
            Console.WriteLine($"Television power is now: {tv.Power}");



           


        }

    }


}


