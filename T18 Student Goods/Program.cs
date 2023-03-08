using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace T18_Student_Goods
{
    class Bookshelf
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }

    }
    class Book : Bookshelf
    {
        public int Pages { get; set; }
        public string writer { get; set; }
    }
    class Phone : Bookshelf 
    {
        public string OS { get; set; }
        public int Memory { get; set; }
    }
    class Tablet : Bookshelf 
    {
        public int Ram { get; set; }
        public bool Camera { get; set; }
    }
    class Laptop : Bookshelf
    {
        public double ScreenSize { get; set; }
        public string CPU { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book
            {
                Name = "Rich dad poor dad",
                Price = 14.99,
                Year = 2017,
                Pages = 336,
                writer = "Robert T. Kiyosaki"
            };
            Phone phone = new Phone 
            {
                Name = "8T",
                Brand="OnePlus",
                Price= 399.99,
                Year=2020,
                OS = "Android",
                Memory = 128
            };
            Tablet tablet = new Tablet
            {
                Name = "Galaxy Tab S6",
                Brand = "Samsung",
                Price = 449.00,
                Year = 2022,
                Ram = 16,
                Camera = true
            };
            Laptop laptop = new Laptop
            {
                Name="Legion 5",
                Brand="Lenovo",
                Price=1299.99,
                Year=2022,
                ScreenSize=15.6,
                CPU="AMD Ryzen"
            };

            Console.WriteLine($"Book: {book.Name}\n Writer: {book.writer}\n Price: {book.Price}€\n Year:{book.Year}\n Pages: {book.Pages}" );
            Console.WriteLine($"Phone: {phone.Name}\n Brand: {phone.Brand}\n Price: {phone.Price}€\n Year:{phone.Year}\n OS: {phone.OS}\n Memory: {phone.Memory}");
            Console.WriteLine($"Tablet: {tablet.Name}\n Brand: {tablet.Brand}\n Price: {tablet.Price}€\n Year:{tablet.Year}\n RAM: {tablet.Ram}\n Camera: {tablet.Camera}");
            Console.WriteLine($"Laptop: {laptop.Name}\n Brand: {laptop.Brand}\n Price: {laptop.Price}€\n Year:{laptop.Year}\n Screensize: {laptop.ScreenSize}\n CPU: {laptop.CPU}");
        }
    }
}
