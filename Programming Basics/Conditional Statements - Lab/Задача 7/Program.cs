using System;

namespace Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {

            double hollydayPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            
            double totalPrice = puzzles * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2 ;
            double numToys = puzzles + dolls + bears + minions + trucks ;
            

           if ( numToys >= 50  )
            {
                totalPrice -= totalPrice * 0.25;
                
            }
             totalPrice -= totalPrice * 0.10;
            
            if ( totalPrice > hollydayPrice)
            {
                Console.WriteLine($"Yes! {totalPrice - hollydayPrice:f2} lv left.");
            }
           
            else
            {
                Console.WriteLine($"Not enough money! {hollydayPrice - totalPrice:f2} lv needed.");
            }    



        }
    }
}
