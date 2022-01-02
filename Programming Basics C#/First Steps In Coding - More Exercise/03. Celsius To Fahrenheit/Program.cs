using System;

namespace _03._Celsius_To_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());

            double Fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{Fahrenheit:f2}");
        }
    }
}
