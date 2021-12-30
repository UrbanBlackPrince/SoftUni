using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());

            for (int counter = M; counter >= N; counter--)
            {
                if (counter % 2 == 0 && counter % 3 == 0)
                {
                    if(counter == S)
                    {
                        break;

                    }
                    Console.Write($"{counter} ");
                }

               
            }
        }
    }
}
