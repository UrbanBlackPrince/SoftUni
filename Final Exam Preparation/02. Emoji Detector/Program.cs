using System;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<name>([*]{2})[A-Z][a-z]{2,}([*]{2})|([:]{2})[A-Z][a-z]{2,}([:]{2}))";
            //([*|:]{2})([A-Z][a-z]{2,}+)\1
            var input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection maches = regex.Matches(input);

            long cool = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    cool *= input[i] - 48;
                }
            }
            Console.WriteLine($"Cool threshold: {cool}");
            Console.WriteLine($"{maches.Count} emojis found in the text. \nThe cool ones are:");
            foreach (Match match in maches)
            {
                int cooles = 0;
                string emoji = match.Groups[2].Value;
                for (int i = 0; i < emoji.Length; i++)
                {
                    cooles += emoji[i];
                }
                if (cooles >= cool)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}
