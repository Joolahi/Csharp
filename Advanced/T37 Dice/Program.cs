using System;

namespace T37_Dice
{
    class Dice
    {
        public Random random;
        public Dice() 
        {
            random= new Random();
        }

        public int Roll()
        {
            return random.Next(1, 7);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dice, one test throw value is " + new Dice().Roll());

            Console.Write("How many times you want to throw a dice: ");
            int numThrows = Convert.ToInt32(Console.ReadLine());

            Dice dice = new Dice();
            int[] throws = new int[numThrows];
            int totalSum = 0;
            int[] counts = new int[6];

            for (int i = 0; i < numThrows; i++)
            {
                int value = dice.Roll();
                throws[i] = value;
                totalSum += value;
                counts[value - 1]++;
            }

            double average = (double)totalSum / numThrows;
            Console.WriteLine("Dice is now thrown " + numThrows + " times");
            Console.WriteLine("- average is " + average.ToString("F4"));

            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine("- " + (i + 1) + " count is " + counts[i]);
            }

        }
    }
}
