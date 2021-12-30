using System;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double totalPrice = 0;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    totalPrice = budget * 0.3;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {totalPrice:f2}");
                }
                else if (season == "winter")
                {
                    totalPrice = budget * 0.7;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {totalPrice:f2}");
                }             
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    totalPrice = budget * 0.4;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {totalPrice:f2}");
                }
                else if (season == "winter")
                {
                    totalPrice = budget * 0.8;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {totalPrice:f2}");
                }
            }
            else if (budget > 1000)
            {
                totalPrice = budget * 0.9;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {totalPrice:f2}");

            }
        }
    }
}
