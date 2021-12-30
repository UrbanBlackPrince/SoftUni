using System;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int degrees = int.Parse(Console.ReadLine());
            string dayAndNight = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            if (degrees >= 10 && degrees <= 18)
            {
                switch (dayAndNight)
                {
                    case "Morning":
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                        break;
                    case "Afternoon":
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                }
            }

            else if (degrees > 18 && degrees <= 24)
            {
                switch (dayAndNight)
                {
                    case "Morning":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    case "Afternoon":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                }
            }

            else if (degrees >= 25)
            {
                switch (dayAndNight)
                {
                    case "Morning":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    case "Afternoon":
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                        break;
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                }
            }


            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");




        }
    }
}
