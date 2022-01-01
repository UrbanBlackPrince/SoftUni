using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split();
            string[] array2 = Console.ReadLine().Split();

            foreach (var item2 in array2)
            {
                foreach (var item1 in array1)
                {
                    if (item1 == item2)
                    {
                        Console.Write(item1 + ' ');
                    }
                }
            }
        }
    }
}
