using System;
namespace ATMApp
{
    class ATMEx
    {
        static void Main(String[] args)
        {
            decimal accountBalance = 50000.00m;
            Console.WriteLine("Welcome to Bhargav's Bank");
            Console.WriteLine("Enter amount to withdraw");
            decimal withdawlAmount = Convert.ToDecimal(Console.ReadLine());
            if (withdawlAmount <= accountBalance)
            {
                accountBalance -= withdawlAmount;
                Console.WriteLine($"Withdrawl Successfull! Remaining Balance: ₹{accountBalance}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance. Transaction declined");
            }
        }
    }
}