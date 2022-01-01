using System;
using System.Linq;

namespace _06._Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[3];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = char.Parse(Console.ReadLine());
            }

            arr = arr.Reverse().ToArray();

            foreach (var t in arr)
            {
                Console.Write(t + " ");
            }
        }
    }
}
