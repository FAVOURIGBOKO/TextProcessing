using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
           namespace CoffeeOrderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> menu = new Dictionary<string, Dictionary<string, double>>()
            {
                { "Espresso", new Dictionary<string, double> { { "Small", 2.00 }, { "Medium", 3.00 }, { "Large", 4.00 } } },
                { "Latte", new Dictionary<string, double> { { "Small", 2.50 }, { "Medium", 3.50 }, { "Large", 4.50 } } },
                { "Cappuccino", new Dictionary<string, double> { { "Small", 2.75 }, { "Medium", 3.75 }, { "Large", 4.75 } } },
                { "Americano", new Dictionary<string, double> { { "Small", 2.25 }, { "Medium", 3.25 }, { "Large", 4.25 } } },
            };

            List<(string Coffee, string Size, double Price)> order = new List<(string, string, double)>();
            string userInput = "";

            Console.WriteLine("Welcome to the Online Coffee Ordering System!\n");

            do
            {
 Console.WriteLine("Available Coffees:");
                int index = 1;
                foreach (var item in menu)
                {
                    Console.WriteLine($"{index}. {item.Key}");
                    index++;
                }

                Console.Write("\nEnter the number of the coffee you want to order: ");
                int coffeeChoice = Convert.ToInt32(Console.ReadLine());
                string selectedCoffee = new List<string>(menu.Keys)[coffeeChoice - 1];

                Console.WriteLine("Available Sizes: Small, Medium, Large");
                Console.Write("Enter size: ");
                string size = Console.ReadLine().Trim();

                if (!menu[selectedCoffee].ContainsKey(size))
                {
                    Console.WriteLine("Invalid size selected. Try again.");
                    continue;
                }

                double price = menu[selectedCoffee][size];
                order.Add((selectedCoffee, size, price));
                Console.WriteLine($"Added {size} {selectedCoffee} - ${price:F2} to your order.\n");

 Console.Write("Do you want to add another item? (yes/no): ");
                userInput = Console.ReadLine().Trim().ToLower();

            } while (userInput == "yes");

            Console.WriteLine("\n--- Order Summary ---");
            double total = 0;
            foreach (var item in order)
            {
                Console.WriteLine($"{item.Size} {item.Coffee} - ${item.Price:F2}");
                total += item.Price;
            }

            Console.WriteLine($"\nTotal Amount: ${total:F2}");
            Console.WriteLine("Thank you for your order!");
        }
    }
}
