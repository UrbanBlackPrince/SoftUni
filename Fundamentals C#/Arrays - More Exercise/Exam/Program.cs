using System;
using System.Linq;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            while(input != "end")
            {
                string[] tokens = input
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);

                int firstNum = 0;
                int secondNum = 0;

                switch (tokens[0])
                {
                    case "swap":
                        {
                            firstNum = int.Parse(tokens[1]);
                            secondNum = int.Parse(tokens[2]);

                            int currNum = numbers[firstNum];
                            numbers[firstNum] = numbers[secondNum];
                            numbers[secondNum] = currNum;
                            break;
                        }

                    case "multiply":
                        firstNum = int.Parse(tokens[1]);
                        secondNum = int.Parse(tokens[2]);

                        numbers[firstNum] *= numbers[secondNum];
                        break;
                    case "decrease":
                        {
                            for (int j = 0; j < numbers.Length; j++)
                            {
                                numbers[j] -= 1;
                            }

                            break;
                        }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(",", numbers));

        }
    }
}
