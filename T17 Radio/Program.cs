using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T17_Radio
{
    class ElectricalDevice
    {
        public bool On { get; protected set; }
        public float Power { get; set; }
        public ElectricalDevice(float power)
        {
            On = false;
            Power = power;
        }
        public virtual void TurnOn()
        { On = true; }
        public virtual void TurnOff()
        { On = false; }

    }
      class PortableRadio : ElectricalDevice 
    {
        public int volume;
        public float channel;

        public PortableRadio(float power) : base(power) 
        {
            volume = 0;
            channel = 2000.0f;
        }
        public override void TurnOn()
        {
            base.TurnOn();
            volume = 0; 
            channel = 2000.0f;
        }
        public override void TurnOff()
        {
            base.TurnOff();
            volume = 0;
            channel = 2000.0f; 
        }
        public void SetVolume(int Volume)
        {
            if (On == true) 
            {
                volume = Volume;
            }
            else 
            {
                Console.WriteLine("Turn radio on!");
            }
        }
        public void SetChannel(float Channel)
        {
            if (On == true)
            {
                channel = Channel;
            }
            else
            {
                Console.WriteLine("Turn radio on!");
            }
        }
        public override string ToString()
       
        {
            return "Power: " + Power + "watts\n" +
                "On: " + On + "\n" +
                "Volume: " + volume + "\n" +
                "Channel: " + channel + "Hz";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PortableRadio radio = new PortableRadio(10.0f);
            Console.WriteLine(radio.ToString());
            radio.TurnOn();
            radio.SetVolume(5);
            radio.SetChannel(2152.0f);

            Console.WriteLine(radio.ToString());
            radio.TurnOff();
            radio.SetVolume(12);
            radio.SetChannel(1588.0f);
        }
    }
}
