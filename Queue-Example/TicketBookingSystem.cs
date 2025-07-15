using System;
using System.Collections.Generic;

class TicketBookingSystem {
    static void Main() {
        Queue<string> ticketQueue = new Queue<string>();
        int maxTickets = 5; // Total tickets available
        bool running = true;

        Console.WriteLine("🎥 Welcome to Friday Cineplex!");
        Console.WriteLine("Commands: book <name>, cancel, serve, status, exit");

        while (running) {
            Console.Write("\nCommand: ");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            switch (parts[0].ToLower()) {
                case "book":
                    if (parts.Length < 2) {
                        Console.WriteLine("⚠️ Please enter a name to book.");
                        break;
                    }
                    string customer = parts[1];
                    if (ticketQueue.Count < maxTickets) {
                        ticketQueue.Enqueue(customer);
                        Console.WriteLine($"✅ Ticket booked for {customer}");
                    } else {
                        Console.WriteLine("❌ Tickets sold out!");
                    }
                    break;

                case "serve":
                    if (ticketQueue.Count > 0) {
                        string servedCustomer = ticketQueue.Dequeue();
                        Console.WriteLine($"🎫 {servedCustomer} has been served. Enjoy the movie!");
                    } else {
                        Console.WriteLine("🛑 No one in the queue.");
                    }
                    break;

                case "cancel":
                    Console.WriteLine("❎ Canceling not supported in basic Queue (FIFO). Try serving next.");
                    break;

                case "status":
                    Console.WriteLine("📋 Current Queue:");
                    foreach (string name in ticketQueue)
                        Console.WriteLine($"- {name}");
                    break;

                case "exit":
                    running = false;
                    Console.WriteLine("👋 Booking system closed.");
                    break;

                default:
                    Console.WriteLine("❌ Unknown command. Try: book, serve, status, exit");
                    break;
            }
        }
    }
}
