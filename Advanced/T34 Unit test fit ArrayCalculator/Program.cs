using System;

namespace UnitTestArrayCalculator
{
    public class ArrayCalculator
    {
        // Methods
        public static double Sum(double[] NumArray)
        {
            return Math.Round(NumArray.Sum(), 2);
        }

        public static double Average(double[] NumArray)
        {
            return Math.Round(NumArray.Average(), 2);
        }

        public static double Min(double[] NumArray)
        {
            return Math.Round(NumArray.Min(), 2);
        }

        public static double Max(double[] NumArray)
        {
            return Math.Round(NumArray.Max(), 2);
        }


    }
    class Program
    {
        static void Main()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };

            // Call static calculation methods of ArrayCalculator class and print results
            Console.WriteLine("Sum: " + ArrayCalculator.Sum(array));
            Console.WriteLine("Average: " + ArrayCalculator.Average(array));
            Console.WriteLine("Min: " + ArrayCalculator.Min(array));
            Console.WriteLine("Max: " + ArrayCalculator.Max(array));

            // Test with an empty array
            double[] emptyArray = { };
            
                Console.WriteLine("Sum: " + ArrayCalculator.Sum(emptyArray));
                Console.WriteLine("Average: " + ArrayCalculator.Average(emptyArray));
                Console.WriteLine("Min: " + ArrayCalculator.Min(emptyArray));
                Console.WriteLine("Max: " + ArrayCalculator.Max(emptyArray));

           // How the methods of the ArrayCalcs class work if you pass an empty double[] array as a parameter: double[] array = { };
            // answer: Empty array breaks  on average, min and max, becouse u can´t take average of nothing, same as MIN and MAX.

    }
    }
}