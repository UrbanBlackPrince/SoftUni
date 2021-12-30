using System;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string typeOfFlowers = Console.ReadLine();
            int numFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalPrice = 0;


            switch (typeOfFlowers)
            {
                case "Roses":
                    totalPrice = numFlowers * 5;

                    if (numFlowers > 80)
                    {
                        totalPrice -= totalPrice * 0.10;
                    }

                    break;
                case "Dahlias":
                    totalPrice = numFlowers * 3.80;

                    if (numFlowers > 90)
                    {
                        totalPrice -= totalPrice * 0.15;
                    }

                    break;
                case "Tulips":
                    totalPrice = numFlowers * 2.80;

                    if (numFlowers > 80)
                    {
                        totalPrice -= totalPrice * 0.15;
                    }

                    break;
                case "Narcissus":
                    totalPrice = numFlowers * 3;

                    if (numFlowers < 120)
                    {
                        totalPrice += totalPrice * 0.15;
                    }

                    break;
                case "Gladiolus":
                    totalPrice = numFlowers * 2.50;

                    if (numFlowers < 80)
                    {
                        totalPrice += totalPrice * 0.20;
                    }

                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {numFlowers} {typeOfFlowers} and {moneyLeft:f2} leva left.");

            }
            else if (budget < totalPrice)
            {
                double moneyNeed = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeed:f2} leva more.");
            }
        }
    }
}
