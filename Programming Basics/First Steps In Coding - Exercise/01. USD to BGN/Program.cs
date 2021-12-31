using System;

namespace _01._USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            const double USDrate = 1.79549;
            double USD = double.Parse(Console.ReadLine());

            double convertBGN = USD * USDrate;
            Console.WriteLine($"{convertBGN:f2}");
        }
    }
}
