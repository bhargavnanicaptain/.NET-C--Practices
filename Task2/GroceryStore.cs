using System;

namespace GroceryApp {
    class GroceryStore {
        static void Main(string[] args) {
            bool running = true;

            while (running) {
                Console.WriteLine("\n====== Grocery Discount Menu ======");
                Console.WriteLine("1. Fruits");
                Console.WriteLine("2. Dairy");
                Console.WriteLine("3. Snacks");
                Console.WriteLine("4. Exit");
                Console.Write("Select a category (1–4): ");
                string choice = Console.ReadLine();

                switch (choice) {
                    case "1":
                        Console.WriteLine("Enter quantity of fruits:");
                        int fruitQty = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter unit price of fruit:");
                        double fruitPrice = Convert.ToDouble(Console.ReadLine());

                        double fruitTotal = fruitQty * fruitPrice;
                        if (fruitQty >= 5) {
                            fruitTotal -= fruitTotal * 0.10;
                            Console.WriteLine("10% discount applied.");
                        }

                        Console.WriteLine($"Total price for fruits: Rs. {fruitTotal}\n");
                        break;

                    case "2":
                        Console.WriteLine("Enter quantity of dairy items:");
                        int dairyQty = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter unit price of dairy item:");
                        double dairyPrice = Convert.ToDouble(Console.ReadLine());

                        double dairyTotal = dairyQty * dairyPrice;

                        if (dairyQty >= 3) {
                            double discount = dairyTotal * 0.05;
                            dairyTotal -= discount;
                            Console.WriteLine("5% discount applied.");
                                            }

                        Console.WriteLine($"Total price for dairy items: Rs. {dairyTotal}\n");
                        break;

                    case "3":
                        Console.WriteLine("Enter quantity of snacks:");
                        int snackQty = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter unit price of snack:");
                        double snackPrice = Convert.ToDouble(Console.ReadLine());

                        int freeSnacks = snackQty / 3;
                        int payableSnacks = snackQty - freeSnacks;
                        double snackTotal = payableSnacks * snackPrice;

                        Console.WriteLine($"{freeSnacks} snack(s) free under Buy 2 Get 1 offer.");
                        Console.WriteLine($"Total price for snacks: Rs. {snackTotal}\n");
                        break;


                    case "4":
                        Console.WriteLine("Thank you for using the Grocery App!");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please select 1–4.");
                        break;
                }
            }
        }
    }
}
