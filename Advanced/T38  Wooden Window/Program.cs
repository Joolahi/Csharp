using System;

namespace T38_Wooden_Window
{
    class Window
    {
        public double width;
        public double height;

        public Window(double widht, double height) 
        {
            this.width = widht;
            this.height = height;

        }

        public double WindowArea() 
        {
            return width * height / 10000;
        }

        public double Circumference()
        { 
            return 2 * (width + height); 
        }

        public double SquareMeter() 
        {
            double woodUsage = Circumference() / 100; // Assuming wood usage is 1 cm^2 per linear centimeter
            double glassUsage = WindowArea() * 3 / 10000;  // Assuming glass usage is 1 cm^2 per square centimeter
            return woodUsage + glassUsage;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter window width (cm): ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter window height (cm): ");
            double height = Convert.ToDouble(Console.ReadLine());

            Window window = new Window(width, height);

            Console.WriteLine("Area of the window: {0} square meters", window.WindowArea());
            Console.WriteLine("Circumference of the window: {0} centimeters", window.Circumference());
            Console.WriteLine("Usage of wood and glass in square meter: {0} square meters", window.SquareMeter());
        }
    }
}