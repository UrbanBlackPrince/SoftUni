using System;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string simbols = Console.ReadLine();

            double result = 0.0;

            switch (simbols)
            {
                case "+":
                    result = num1 + num2;

                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{num1} + {num2} = {Math.Round(result, 2)} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} + {num2} = {Math.Round(result, 2)} - odd");
                    }

                    break;
                case "-":
                    result = num1 - num2;

                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{num1} - {num2} = {Math.Round(result, 2)} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} - {num2} = {Math.Round(result, 2)} - odd");
                    }

                    break;
                case "*":
                    result = num1 * num2;

                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{num1} * {num2} = {Math.Round(result, 2)} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} * {num2} = {Math.Round(result, 2)} - odd");
                    }

                    break;
                case "/":
                    result = num1 / num2;

                    if (num2 != 0)
                    {
                        Console.WriteLine($"{num1} / {num2} = {result:f2}");
                    }
                    

                    else if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }

                    break;
                case "%":
                    result = num1 % num2;

                    if( num2 != 0)
                    { 
                        Console.WriteLine($"{num1} % {num2} = {Math.Round(result, 1)}");
                    }
                    

                    else if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }

                    break;
            }


        }
    }
}
