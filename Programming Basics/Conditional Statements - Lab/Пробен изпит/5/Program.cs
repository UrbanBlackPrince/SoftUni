using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int adultsCounter = 0;
            int kidsCounter = 0;

            int moneyForToys = 0;
            int moneyForSweaters = 0;

            int totalToys = 0;
            int totalSweaters = 0;

            while(input != "Christmas")
            {
                int num = int.Parse(input);
                
                if (num <= 16)
                {
                    kidsCounter++;
                }
                if (num > 16)
                {
                    adultsCounter++;
                   
                }
               
                input = Console.ReadLine();
            }

            moneyForToys = kidsCounter * 5;
            totalToys += moneyForToys;

            moneyForSweaters = adultsCounter * 15;
            totalSweaters += moneyForSweaters;

            Console.WriteLine($"Number of adults: {adultsCounter} ");
            Console.WriteLine($"Number of kids: {kidsCounter} ");
            Console.WriteLine($"Money for toys: {totalToys} ");
            Console.WriteLine($"Money for sweaters: {totalSweaters} ");



        }
    }
}
