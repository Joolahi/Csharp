using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T30_Interdace
{
    public interface ICartItem
    {
        string Name { get; }
        float Price { get; }
        int Quantity { get; set; }
        float TotalPrice { get; }
    }

    public class Toys : ICartItem
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        public float TotalPrice
        {
            get { return Price * Quantity; }
        }
    }

    public class Electronics : ICartItem
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        public float TotalPrice
        {
            get { return Price * Quantity; }
        }
    }

    public class ShoppingCart
    {
        public List<ICartItem> items;

        //Items in shopping cart are in a list
        public ShoppingCart()
        {
            items = new List<ICartItem>();
        }

        public void AddItem(ICartItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(ICartItem item)
        {
            items.Remove(item);
        }

        public void Clear()
        {
            items.Clear();
        }

        //Get prize to itmes in cart
        public float GetTotalPrice()
        {
            float total = 0;
            foreach (var item in items)
            {
                total += item.TotalPrice;
            }
            return total;
        }

        //For printing items that are in shopping cart
        public void PrintItems()
        {
            Console.WriteLine("Shopping Cart Items:");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name} ({item.Quantity}): {item.TotalPrice:C}");
            }
            Console.WriteLine($"Total Price: {GetTotalPrice():C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create some items
            ICartItem toys = new Toys()
            {
                Name = "Action figure",
                Price = 24.99f,
                Quantity = 2
            };

            ICartItem electronics = new Electronics()
            {
                Name = "iPhone 13 Pro",
                Price = 1299.99f,
                Quantity = 1
            };

            // Create a shopping cart
            var cart = new ShoppingCart();

            // Add items to the cart
            cart.AddItem(toys);
            cart.AddItem(electronics);

            // Print the items and total price
            cart.PrintItems();

            // Remove an item from the cart
            cart.RemoveItem(toys);

            // Print the items and total price again
            cart.PrintItems();

            // Clear the cart
            cart.Clear();

            // Print the items and total price again
            cart.PrintItems();
        }
    }
}
