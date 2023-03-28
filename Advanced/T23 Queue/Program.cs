using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T23_Queue
{
    public class CheckoutQueue
    {
        private Queue<string> queue = new Queue<string>();

        public void GoToQueue(string customer)
        {
            queue.Enqueue(customer);
        }

        public string ExitQueue()
        {
            return queue.Count > 0 ? queue.Dequeue() : null;
        }

        public int Length => queue.Count;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckoutQueue checkoutQueue = new CheckoutQueue();

            while (true)
            {
                Console.WriteLine("Enter customer name to add to the queue or press Enter to exit:");
                string input = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                checkoutQueue.GoToQueue(input);
                Console.WriteLine("Added customer '{0}' to the queue.", input);
            }

            Console.WriteLine();
            if (checkoutQueue.Length == 0)
            {
                Console.WriteLine("Queue is empty.");
            }
            else
            {
                Console.WriteLine("Customers in queue:");
                while (checkoutQueue.Length > 0)
                {
                    string customer = checkoutQueue.ExitQueue();
                    Console.WriteLine("Serving customer '{0}'.", customer);
                    if (checkoutQueue.Length == 0)
                    {
                        Console.WriteLine("Queue is now empty.");
                    }

                }

            }
        }
    }
}
