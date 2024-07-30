using System;
using System.Collections.Generic;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of Pizza
            Pizza pizza1 = new Pizza("small", 1, 2, 1);
            Pizza pizza2 = new Pizza("medium", 2, 3, 0);

            // Displaying pizza details
            Console.WriteLine("Pizza 1:");
            Console.WriteLine(pizza1.GetDescription());
            Console.WriteLine($"Cost: ${pizza1.CalcCost()}");

            Console.WriteLine("\nPizza 2:");
            Console.WriteLine(pizza2.GetDescription());
            Console.WriteLine($"Cost: ${pizza2.CalcCost()}");

            // Example of updating properties
            pizza2.Size = "large";
            pizza2.CheeseToppings = 4;

            Console.WriteLine("\nUpdated Pizza 2:");
            Console.WriteLine(pizza2.GetDescription());
            Console.WriteLine($"Cost: ${pizza2.CalcCost()}");

            // Storing records in a List
            List<Pizza> pizzas = new List<Pizza>();
            pizzas.Add(pizza1);
            pizzas.Add(pizza2);

            // Displaying all pizzas in the list
            Console.WriteLine("\nAll Pizzas:");
            foreach (var pizza in pizzas)
            {
                Console.WriteLine(pizza.GetDescription());
                Console.WriteLine($"Cost: ${pizza.CalcCost()}");
                Console.WriteLine();
            }

            // Keep console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
