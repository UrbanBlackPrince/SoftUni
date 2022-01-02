using System;
using System.Linq;

namespace _05._Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] len = new int[nums.Length];
            int[] prev = new int[nums.Length];
            int maxLength = 0;
            int maxIndex = -1;

            for (int p = 0; p < nums.Length; p++)
            {
                len[p] = 1;
                prev[p] = -1;

                for (int left = 0; left < p; left++)
                {
                    if ((nums[left] < nums[p]) && (len[left] + 1 > len[p]))
                    {
                        len[p] = len[left] + 1;
                        prev[p] = left;
                    }
                }

                if (len[p] > maxLength)
                {
                    maxLength = len[p];
                    maxIndex = p;
                }
            }

           
            int[] output = new int[maxLength];
            int currentIndex = maxIndex;

            for (int i = output.Length - 1; i >= 0; i--)
            {
                output[i] = nums[currentIndex];
                currentIndex = prev[currentIndex];
            }

            Console.WriteLine(string.Join(' ', output));
        }
    }
}
