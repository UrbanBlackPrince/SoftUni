using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> totalPeople = new Dictionary<string, int>();
            Dictionary<string, int> totalGold = new Dictionary<string, int>();

            while(input != "Sail")
            {
                string[] tokens = input
                    .Split("||")
                    .ToArray();

                string sity = tokens[0];
                int popylation = int.Parse(tokens[1]);
                int gold = int.Parse(tokens[2]);

                totalPeople[sity] = popylation;
                totalGold[sity] = gold;

                input = Console.ReadLine();
            }
            var command = Console.ReadLine().Split("=>").ToArray();

            while(command[0] != "End")
            {
                if(command[0] == "Plunder")
                {
                    string town = command[1];
                    int peopleToKill = int.Parse(command[2]);
                    int goldToStoll = int.Parse(command[3]);

                    totalPeople[command[1]] -= peopleToKill;
                    totalGold[command[1]] -= goldToStoll;
                    Console.WriteLine($"{town} plundered! {goldToStoll} gold stolen, {peopleToKill} citizens killed.");

                    if (totalPeople[command[1]] <= 0 || totalGold[command[1]] <= 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map! ");
                        totalGold.Remove(command[1]);
                        totalPeople.Remove(command[1]);
                    }
                }
                if(command[0] == "Prosper")
                {
                    string town = command[1];
                    int gold = int.Parse(command[2]);
                    if (gold <= 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        totalGold[command[1]] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {totalGold[command[1]]} gold. ");
                    }

                }
                command = Console.ReadLine().Split("=>").ToArray();
            }
            if(totalPeople.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {totalPeople.Count} wealthy settlements to go to:");
                Console.WriteLine(string.Join($"{Environment.NewLine}", totalPeople
                   .OrderByDescending(x => x.Value)
                   .ThenBy(x => x.Key)
                   .Select(x => $"{x.Key} -> Population:  {x.Value} citizens, Gold:  {totalGold[x.Key]} kg ")));
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            
        }
    }
}
