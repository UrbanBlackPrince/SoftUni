using System;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            //string pattern = @"([\||#])([A-Z][a-z]+|[A-Z][a-z]+ [A-Z][a-z]+)([\||#])([0-9]{2}\/[0-9]{2}\/[0-9]{2})([\||#])([0-9]+)";
            string pattern = @"([|#])(?<name>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d{1,5})\1";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            double totalCalories = 0;

            foreach (Match item in matches)
            {
                int caloriesToAdd = int.Parse(item.Groups[6].Value);
                totalCalories += caloriesToAdd;
            }
            double caloriesToLive = (Math.Floor(totalCalories / 2000));

            Console.WriteLine($"You have food to last you for: {caloriesToLive} days! ");

            foreach (Match final in matches)
            {
                string item = final.Groups[2].Value;
                string date = final.Groups[4].Value;
                string calorries = final.Groups[6].Value;
                Console.WriteLine($"Item: {item}, Best before: {date}, Nutrition: {calorries}");
            }
    }
}
