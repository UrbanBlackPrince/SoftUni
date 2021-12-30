using System;

namespace Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string mouth = Console.ReadLine();
            int overnight = int.Parse(Console.ReadLine());

            double totalPriceStudio = 0;
            double totalPriceApartament = 0;

            const double mayAndOctoberStudioPrice = 50;
            const double mayAndOctoberApartamentPrice = 65;
            const double juneAndSeptemberStudioPrice = 75.20;
            const double juneAndSeptemberApartamentPrice = 68.70;
            const double julyAndAugustStudioPrice = 76;
            const double julyAndAugustApartamentPrice = 77;

            
            switch (mouth)
            {
                case "May":
                case "October":
                    totalPriceStudio = overnight * mayAndOctoberStudioPrice;
                    totalPriceApartament = overnight * mayAndOctoberApartamentPrice;

                    if(overnight > 7 && overnight < 14)
                    {
                        totalPriceStudio -= totalPriceStudio * 0.05;
                    }
                    else if (overnight > 14)
                    {
                        totalPriceStudio -= totalPriceStudio * 0.3;
                    }
                    break;

                case "June":
                case "September":
                    totalPriceStudio = overnight * juneAndSeptemberStudioPrice;
                    totalPriceApartament = overnight * juneAndSeptemberApartamentPrice;
                    if (overnight > 14)
                    {
                        totalPriceStudio -= totalPriceStudio * 0.2;
                    }
                    break;

                case "July":
                case "August":
                    totalPriceStudio = overnight * julyAndAugustStudioPrice;
                    totalPriceApartament = overnight * julyAndAugustApartamentPrice;
                    break;
            }
            if (overnight > 14)
            {
                totalPriceApartament -= totalPriceApartament * 0.1;
            }

            Console.WriteLine($"Apartment: {totalPriceApartament:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");


        }
    }
}
