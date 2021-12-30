using System;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double premierePrice = 12.00;
            const double normalPrice = 7.50;
            const double discountPrice = 5.00;

            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columbs = int.Parse(Console.ReadLine());

            double income = 0;

            switch (type)
            {
                case "Premiere":
                    income = rows * columbs * premierePrice;
                    break;
                case "Normal":
                    income = rows * columbs * normalPrice;                 
                    break;
                case "Discount":
                    income = rows * columbs * discountPrice;                 
                    break;
               
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
