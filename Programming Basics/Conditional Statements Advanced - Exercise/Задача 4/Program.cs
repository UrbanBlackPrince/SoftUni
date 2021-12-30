using System;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numFishmen = int.Parse(Console.ReadLine());

            double loanBoat = 0;
          
            switch (season)
            {
                case "Spring":
                    loanBoat = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    loanBoat = 4200;
                    break;
                case "Winter":
                    loanBoat = 2600;
                    break;
            }
            if (numFishmen <= 6)
            {
                loanBoat -= loanBoat * 0.1;
            }
            else if (numFishmen >= 7 && numFishmen <= 11)
            {
                loanBoat -= loanBoat * 0.15;
            }
            else if (numFishmen > 12)
            {
                loanBoat -= loanBoat * 0.25;
            }

            if (numFishmen % 2 == 0 && season != "Autumn")
            {
                loanBoat -= loanBoat * 0.05;
            }
            

            if (budget >= loanBoat )
            {
                double moneyLeft = budget - loanBoat;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeed = loanBoat - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeed:f2} leva.");
            }
        }
    }
}
