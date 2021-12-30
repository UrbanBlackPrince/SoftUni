using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBoxPaint = int.Parse(Console.ReadLine());
            int numBWallpapersRols = int.Parse(Console.ReadLine());
            double priceOnePairGloves  = double.Parse(Console.ReadLine());
            double priceOneBrush = double.Parse(Console.ReadLine());

            double totalBoxPaint = numBoxPaint * 21.50;
            double totalPriceWallpapers = numBWallpapersRols * 5.20;
            double numForGloves = Math.Ceiling(numBWallpapersRols * 0.35);
            double  ForBrush = Math.Floor(numBoxPaint * 0.48);

            double totalPriceGloves = numForGloves * priceOnePairGloves;
            double totalPriceBrush = ForBrush * priceOneBrush;

            double totalCoastAll = totalBoxPaint + totalPriceWallpapers + +totalPriceGloves + totalPriceBrush;
            double delivery = totalCoastAll * 0.0666666667;

            Console.WriteLine($"This delivery will cost {delivery:f2} lv."); 












        }
    }
}
