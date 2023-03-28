using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T28_Refrigerator
{
    class Food
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Food(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
    }

    class Vegetable : Food
    {
        public Vegetable(string name, int quantity) : base(name, quantity) { }
    }

    class Meat : Food
    {
        public Meat(string name, int quantity) : base(name, quantity) { }
    }

    class Drink : Food
    {
        public Drink(string name, int quantity) : base(name, quantity) { }
    }

    class Refrigerator
    {
        private List<Food> items = new List<Food>();

        public void AddFoodItem(Food item)
        {
            items.Add(item);
        }

        public void RemoveFoodItem(Food item)
        {
            items.Remove(item);
        }

        public void ListItems()
        {
            Console.WriteLine("Refrigerator Contains:");
            foreach (Food item in items)
            {
                Console.WriteLine(item.Quantity + " " + item.Name);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Refrigerator fridge = new Refrigerator();

            Vegetable lettuce = new Vegetable("Lettuce", 2);
            Vegetable carrot = new Vegetable("Carrot", 3);

            Meat chicken = new Meat("Chicken", 1);

            Drink milk = new Drink("Milk", 1);
            Drink cola = new Drink("Coca-Cola", 2);

            fridge.AddFoodItem(lettuce);
            fridge.AddFoodItem(carrot);
            fridge.AddFoodItem(chicken);
            fridge.AddFoodItem(milk);
            fridge.AddFoodItem(cola);

            fridge.ListItems();

            fridge.RemoveFoodItem(lettuce);
            fridge.RemoveFoodItem(cola);

            fridge.ListItems();
        }

    }
}
