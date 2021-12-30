using System;

namespace Задача_8
{
    class Program
    {
        static void Main(string[] args)
        {

            int numOfDogs = int.Parse(Console.ReadLine());
            int numRestAnimals = int.Parse(Console.ReadLine());

            double foodForDogs = numOfDogs * 2.50;
            double foodRestAnimals = numRestAnimals * 4;
            double result = foodForDogs + foodRestAnimals;

            Console.WriteLine($"{result} lv.");





        }
    }
}
