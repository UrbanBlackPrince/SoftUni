using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> input = new SortedDictionary<double, int>();

            foreach (int number in numbers)
            {
                if (input.ContainsKey(number))
                {
                    input[number]++;
                }
                else
                {
                    input.Add(number, 1);
                }
            }

            foreach (var number in input)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
