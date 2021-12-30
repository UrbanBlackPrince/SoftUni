using System;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int numPages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int numDays = int.Parse(Console.ReadLine());

            double totalTimeReadBook = numPages / pagesPerHour;
            double hoursPerDay = totalTimeReadBook / numDays;

            Console.WriteLine(hoursPerDay);






        }
    }
}
