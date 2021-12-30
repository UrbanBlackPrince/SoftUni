using System;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int numStatics = int.Parse(Console.ReadLine());
            double clothesForOneStatic = double.Parse(Console.ReadLine());

            double filmDecor = budget * 0.10;
            double priceAllClothing = numStatics * clothesForOneStatic;

            if (numStatics > 150)
            {
                double discount = priceAllClothing * 0.10;
                priceAllClothing -= discount;
            }

            double totalCoastFilm = filmDecor + priceAllClothing;
            double moneyLeft = budget - totalCoastFilm;
            double moneyNeed = totalCoastFilm - budget;


            if (totalCoastFilm > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeed:F2} leva more.");
            }

            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
            }



        }
    }
}
