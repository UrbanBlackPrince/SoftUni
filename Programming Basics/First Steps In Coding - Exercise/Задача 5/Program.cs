using System;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {

            double rent = double.Parse(Console.ReadLine());

            double priceCake = rent * 0.20 ;
            double priceDrinks = priceCake  * 0.55;  
            double priceAnimator = rent / 3;

            double total = rent + priceDrinks + priceCake + priceAnimator;

            Console.WriteLine(total);















        }
    }
}
