using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int numBottlesBeer = int.Parse(Console.ReadLine());
            int numPaketsChips = int.Parse(Console.ReadLine());

            double totalPriceBeer = numBottlesBeer * 1.20;
            double priceForOnePacketChips = totalPriceBeer * 0.45;
            double totalChipsPrice = Math.Ceiling(priceForOnePacketChips * 3);
            double totalSum = totalPriceBeer + totalChipsPrice;

            if(totalSum <= budget)
            {
                double moneyLeft = budget - totalSum;
                Console.WriteLine($"{name} bought a snack and has {moneyLeft:f2} leva left. ");
            }
            else
            {
                double moneyNeed = totalSum - budget;
                Console.WriteLine($"{name} needs {moneyNeed:f2} more leva! ");
            }








        }
    }
}
