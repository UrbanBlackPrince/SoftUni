using System;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {


            int deposit = int.Parse(Console.ReadLine());
            double depositMouth = double.Parse(Console.ReadLine());
            double interestYear = double.Parse(Console.ReadLine());

            double interestSum = deposit * interestYear / 100;
            double interestPerOneMouth = interestSum / 12;
            double totalSum = deposit + depositMouth * interestPerOneMouth;


            Console.WriteLine(totalSum);




        }
    }
}
