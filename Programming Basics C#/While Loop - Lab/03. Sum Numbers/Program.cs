﻿using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            while (sum < number)
            {
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"{sum}");
        }
    }
}
