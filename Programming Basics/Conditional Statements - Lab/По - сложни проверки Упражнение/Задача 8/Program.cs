using System;

namespace Задача_8
{
    class Program
    {
        static void Main(string[] args)
        {

            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int hourHeArrived = int.Parse(Console.ReadLine());
            int minutesHeArrived = int.Parse(Console.ReadLine());

            int difference = 0;
            int hour = 0;
            int minutes = 0;

            examMinutes += examHour * 60;
            minutesHeArrived += hourHeArrived * 60;

            if (minutesHeArrived > examMinutes)
            {
                Console.WriteLine("Late");
                difference = minutesHeArrived - examMinutes;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($" ${hour}:${minutes} hours after the start");
                }
            }
            else if (minutesHeArrived < examMinutes - 30)
            {
                Console.WriteLine("Early");
                difference = examMinutes - minutesHeArrived;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes} hours after the start");
                }
            }
            else 
            {
                Console.WriteLine("On time");
                difference = examMinutes - minutesHeArrived;
                Console.WriteLine($"{difference} minutes before the start");


            }

        }
    }
}
