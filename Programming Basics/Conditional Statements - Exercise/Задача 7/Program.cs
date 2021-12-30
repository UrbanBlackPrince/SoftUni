using System;

namespace Задача_77
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecordInSoconds = double.Parse(Console.ReadLine());
            double distanceInMetres = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double mustSwim = distanceInMetres * timeForOneMeter;
            double realTime = Math.Floor(distanceInMetres / 15) * 12.5;
            double total = mustSwim + realTime;
            double timeDontBeat = total - worldRecordInSoconds;



            if (worldRecordInSoconds < total)
            {
                Console.WriteLine($"No, he failed! He was {timeDontBeat:f2} seconds slower.");

            }

            else if (worldRecordInSoconds > total)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {total:f2} seconds.");

            }
        }
    }
}
