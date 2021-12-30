using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> totalRarity = new Dictionary<string, int>();
            Dictionary<string, int> totalRaiting = new Dictionary<string, int>();

            for (int counter = 0; counter < n; counter++)
            {
                string[] input = Console.ReadLine()
                    .Split("<->")
                    .ToArray();

                string plant = input[0];
                int rarrity = int.Parse(input[1]);

                if (!(totalRarity.ContainsKey(plant)))
                {
                    totalRarity[plant] = rarrity;
                }
                else
                {
                    totalRarity[plant] = rarrity;
                }
            }
            var command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (command[0] != "Exhibition")
            {
                if (command[0] == "Rate")
                {
                    string[] tokens = command[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    string plant = tokens[0];
                    int raiiting = int.Parse(tokens[1]);

                    if (!(totalRaiting.ContainsKey(plant)))
                    {
                        totalRaiting[plant] = raiiting;
                    }
                    else
                    {
                        totalRaiting[plant] += raiiting;
                        
                    }

                }
                else if (command[0] == "Update")
                {
                    string[] tokens = command[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    string plant = tokens[0];
                    int update = int.Parse(tokens[1]);

                    totalRaiting[plant] = update;
                }
                else if (command[0] == "Reset")
                {
                    string[] tokens = command[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    string plant = tokens[0];
                    totalRaiting[plant] = 0;

                }
                else
                {
                    Console.WriteLine("error");

                }
                command = Console.ReadLine().Split(": ").ToArray();
            }
            foreach(var item in )
        }
    }
}
