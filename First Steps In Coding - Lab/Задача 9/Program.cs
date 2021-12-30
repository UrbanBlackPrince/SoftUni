using System;

namespace Задача_9
{
    class Program
    {
        static void Main(string[] args)
        {

            double mLandScaped = double.Parse(Console.ReadLine());

            double priceForLandScapedWholeYard = mLandScaped * 7.61;
            double discount = 0.18 * priceForLandScapedWholeYard;
            double finalPriceAll = priceForLandScapedWholeYard - discount;

            Console.WriteLine($"The final price is: {finalPriceAll} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");



        }
    }
}
