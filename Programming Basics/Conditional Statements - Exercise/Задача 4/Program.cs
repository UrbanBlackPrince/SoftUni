using System;

namespace Задача_44
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string exitUnit = Console.ReadLine();

            double result = 0;

            if (inputUnit == "mm" && exitUnit == "m")
            {
                result = number / 1000;

            }

            else if (inputUnit == "mm" && exitUnit == "cm")
            {
                result = number / 10;
            }


            else if (inputUnit == "cm" && exitUnit == "mm")
            {
                result = number * 10;

            }

            else if (inputUnit == "cm" && exitUnit == "m")
            {
                result = number / 100;
            }

            else if (inputUnit == "m" && exitUnit == "mm")
            {
                result = number * 1000;
            }


            else if (inputUnit == "m" && exitUnit == "cm")
            {
                result = number * 100;
            }


            Console.WriteLine($"{result:f3}");

        }
    }
}
