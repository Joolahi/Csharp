using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T14_Amplifier
{
    class Amplifier
    {
        public int volume;
        public void SetVolume(int changedVolume)
        {
            volume = Math.Max(0, Math.Min(100, changedVolume));
            if (changedVolume < 0) 
            {
                Console.WriteLine("-> Too low volume - Amplifier volume set to: " + volume);
            }
            if (changedVolume > 100) 
            {
                Console.WriteLine("-> Too much volume - Amplifier volume set to: " + volume);
            }
            if (volume > 0 && volume < 100 ) 
            {
                Console.WriteLine("-> Amplifier volume set to: " + volume);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Amplifier amplifier = new Amplifier();
            while (true)
            {
                Console.WriteLine("Give a new volume value (0-100) >");
                string input = Console.ReadLine();
                if (input == string.Empty)
                {
                    break;
                }
                int volume;
                if (int.TryParse(input, out volume))
                {
                    amplifier.SetVolume(volume);

                }
                else
                {
                    Console.WriteLine("Input is not valid");
                }

            }
        }
    }
}
