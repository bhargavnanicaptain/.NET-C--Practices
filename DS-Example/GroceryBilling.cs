using System;
using System.Collections.Generic;

class GroceryBilling {
    static void Main() {
        // Array: Fixed product list
        string[] products = { "Rice", "Wheat", "Sugar", "Milk", "Eggs" };

        // Dictionary: Price Lookup for each product
        Dictionary<string, double> priceList = new Dictionary<string, double>() {
            { "Rice", 60 },
            { "Wheat", 45 },
            { "Sugar", 38 },
            { "Milk", 30 },
            { "Eggs", 6 }
        };

        // List: User's shopping cart
        List<string> cart = new List<string>();
        string input = "";
        double totalBill = 0;

        Console.WriteLine("🛍️ Welcome to FridayMart!");
        Console.WriteLine("Available products:");
        foreach (string product in products) {
            Console.WriteLine($"- {product} : ₹{priceList[product]} per unit");
        }

        Console.WriteLine("\nType the product name to add to cart. Type 'done' to finish:");

        // Accept user items
        while (true) {
            Console.Write("Add to cart: ");
            input = Console.ReadLine();

            if (input.ToLower() == "done") break;

            if (Array.Exists(products, p => p.Equals(input, StringComparison.OrdinalIgnoreCase))) {
                cart.Add(input);
                totalBill += priceList[input];
                Console.WriteLine($"✅ {input} added! Current bill: ₹{totalBill}");
            } else {
                Console.WriteLine("❌ Product not found. Try again.");
            }
        }

        // Final bill
        Console.WriteLine("\n🧾 Final Bill Summary:");
        foreach (string item in cart) {
            Console.WriteLine($"{item} - ₹{priceList[item]}");
        }
        Console.WriteLine($"🧮 Total Amount Due: ₹{totalBill}");
    }
}
