using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> total = new Dictionary<string, List<string>>();

            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string [] tokens = input
                    .Split("|",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string piece = tokens[0];
                string compositor = tokens[1];
                string key = tokens[2];

                total.Add(piece, new List<string>());
                total[piece].Add(compositor);
                total[piece].Add(key);
            }
            var command = Console.ReadLine()
                .Split("|")
                .ToArray();

            while(command[0] != "Stop")
            {
                if (command[0] == "Add")
                {
                    string piece = command[1];
                    string name = command[2];
                    string key = command[3];

                    if (total.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        total.Add(piece, new List<string>());
                        total[piece].Add(name);
                        total[piece].Add(key);

                        Console.WriteLine($"{piece} by {name} in {key} added to the collection!");
                    }
                }
                if(command[0] == "Remove")
                {
                    string piecetoremove = command[1];
                    if(total.ContainsKey(piecetoremove))
                    {
                        total.Remove(piecetoremove);
                        Console.WriteLine($"Successfully removed {piecetoremove}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piecetoremove} does not exist in the collection.");
                    }
                }
                if(command[0] == "ChangeKey")
                {
                    string piece = command[1];
                    string newKey = command[2];

                    if(total.ContainsKey(piece))
                    {
                        total[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");

                    }

                }
                command = Console.ReadLine().Split("|").ToArray();
            }
            foreach (var piece in total.OrderBy(x => x.Key).ThenBy(x => x.Value[0]))
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
            }
        }
    }
}
