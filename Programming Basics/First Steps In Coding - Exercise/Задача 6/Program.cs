using System;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {

            int totalDays = int.Parse(Console.ReadLine());
            int confectioner = int.Parse(Console.ReadLine());
            int numberCakes = int.Parse(Console.ReadLine());
            int numberWaffles = int.Parse(Console.ReadLine());
            int numberPancakes = int.Parse(Console.ReadLine());

            double priceCakes = numberCakes * 45;
            double priceWaffles = numberWaffles * 5.80;
            double pricePancakes = numberPancakes * 3.20;
            double totalSumDay = (priceCakes + priceWaffles + pricePancakes) * confectioner;
            double sumAllCampaign = totalSumDay * totalDays;
            double totalSum = sumAllCampaign / 8;
            double realTotalSum = sumAllCampaign - totalSum;

            Console.WriteLine(realTotalSum);
                
      
        }
    }
}
