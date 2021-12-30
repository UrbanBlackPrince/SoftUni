using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            // string pattern = @"(=)([A-Z][a-z]+)(=)|(\/)([A-Z][a-z]+)(\/)";
            string pattern = @"=([A-Z][a-z]+)=|\/([A-Z][a-z]+)\/";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            List<string> towns = new List<string>();

            int points = 0;

            if(matches.Count > 0)
            {
                foreach(Match item in matches)
                {
                    string place = item.Groups[2].Value;
                    towns.Add(place);
                    if(place.Length == 0)
                    {
                        place = item.Groups[1].Value;
                        towns.Add(place);
                    }
                }
            }
            Console.WriteLine($"Destination:{(string.Join(", ",))}) ");
            foreach (Match items in matches)
            {
                points += items.Length;
            }
            
            if(points > 0)
            {
                Console.WriteLine($"Travel points: {points}");
            }

        }
    }
}
