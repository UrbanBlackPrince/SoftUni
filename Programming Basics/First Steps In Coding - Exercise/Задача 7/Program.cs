using System;

namespace Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {

            double priceStrawberry = double.Parse(Console.ReadLine());
            double quantityBananas = double.Parse(Console.ReadLine());
            double quantityOranges = double.Parse(Console.ReadLine());
            double quantityRaspberry = double.Parse(Console.ReadLine());
            double quantityStrawberry = double.Parse(Console.ReadLine());

            //double priceRaspberry = priceStrawberry / 2;
            //double priceOranges = priceRaspberry * 0.60;
            //double priceBananas = priceRaspberry * 0.20;
            //double totalRaspberry = quantityRaspberry * priceRaspberry;
            //double totalOranges = quantityOranges * priceOranges;
            //double totalBananas = quantityBananas * priceBananas;
            //double totalStrawberry = quantityStrawberry * priceStrawberry;
            //double totalAll = totalBananas + totalOranges + totalRaspberry + totalStrawberry;

            double priceRaspberry = priceStrawberry / 2;
            double priceOranges = priceRaspberry * 0.60;
            double priceBananas = priceRaspberry * 0.20;

            double totalAll = (quantityStrawberry * priceStrawberry) + (quantityBananas * priceBananas) + (quantityOranges * priceOranges) + (quantityRaspberry * priceRaspberry);

            Console.WriteLine(totalAll);

            






















        }
    }
}
