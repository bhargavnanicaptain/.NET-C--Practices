using System;
namespace Packing
{
    class PackingSystem
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Parcel Name: ");
           string? parcel = Console.ReadLine();
            Console.WriteLine("Enter the weight of the parcel");
            decimal weight = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the Dimensions in cm (Length, Width, Height)");
            decimal len = Convert.ToDecimal(Console.ReadLine());
            decimal wid = Convert.ToDecimal(Console.ReadLine());
            decimal hei = Convert.ToDecimal(Console.ReadLine());
            decimal volume = len * wid * hei;
            if (weight <= 10 && volume <= 100000)
            {
                Console.WriteLine($"[{parcel} box]");
                Console.WriteLine($"Total Volume: {volume} cm^3");
                Console.WriteLine("Status: Eligible for standard Shipping");
            }
            else
            {
                Console.WriteLine("Oops! The parcel is exceeding the Weight 10KG and its Volume 100000 cm^3");
            }
        }
    }
}