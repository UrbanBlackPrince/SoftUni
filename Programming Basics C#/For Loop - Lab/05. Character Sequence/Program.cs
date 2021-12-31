using System;

namespace _05._Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int index = 0; index < input.Length; index++)
            {
                Console.WriteLine(input[index]);
            }
        }
    }
}
