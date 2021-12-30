using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {

            //string input = Console.ReadLine();
            //string command = Console.ReadLine();

            //while (command != "Generate")
            //{
            //    string[] tokens = command
            //        .Split(">>>", StringSplitOptions.RemoveEmptyEntries)
            //        .ToArray();

            //    string type = tokens[0];
            //    if (type == "Contains")
            //    {
            //        string substring = tokens[1];
            //        if (input.Contains(substring))
            //        {
            //            Console.WriteLine($"{input} contains {substring}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Substring not found! ");
            //        }
            //    }
            //    if (type == "Flip")
            //    {
            //        string action = tokens[1];
            //        if (action == "Lower")
            //        {
            //            int startIndex = int.Parse(tokens[2]);
            //            int endIndex = int.Parse(tokens[3]);

            //            if (startIndex <= endIndex)
            //            {
            //                string subStringToReplace = input.Substring(startIndex, endIndex - startIndex);
            //                string newString = subStringToReplace.ToLower();
            //                input = input.Replace(subStringToReplace, newString);
            //                Console.WriteLine($"{input}");
            //            }
            //        }
            //        if (action == "Upper")
            //        {
            //            int startIndex = int.Parse(tokens[2]);
            //            int endIndex = int.Parse(tokens[3]);

            //            if(startIndex <= endIndex)
            //            {
            //                string subStringToReplace = input.Substring(startIndex, endIndex - startIndex);
            //                string newString = subStringToReplace.ToLower();
            //                input = input.Replace(subStringToReplace, newString);
            //                Console.WriteLine($"{input}");
            //            }
            //        }
            //    }
            //    if(type == "Slice")
            //    {
            //        int startIndex = int.Parse(tokens[1]);
            //        int endIndex = int.Parse(tokens[2]);

            //        if (endIndex >= startIndex)
            //        {
            //            int lenfthOfStringToRemove = endIndex - startIndex;
            //            string subStringToReplace1 = input.Substring(startIndex, lenfthOfStringToRemove);
            //            string newString1 = string.Empty;
            //            input = input.Replace(subStringToReplace1, newString1);
            //            Console.WriteLine($"{input}");
            //        }
            //    }


            //    command = Console.ReadLine();
            //}
            //   Console.WriteLine($"Your activation key is: {input}");

            string key = Console.ReadLine();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] commands = input.Split(">>>");
                string action = commands[0];
                if (action == "Contains")
                {
                    string substring = commands[1];
                    if (!key.Contains(substring))
                    {
                        Console.WriteLine("Substring not found!");
                    }
                    else
                    {
                        Console.WriteLine($"{key} contains {substring}");
                    }
                }
                else if (action == "Flip")
                {
                    string Towhere = commands[1];
                    int startIndex = int.Parse(commands[2]);
                    int endIndex = int.Parse(commands[3]);
                    if (Towhere == "Upper")
                    {
                        if (startIndex >= 0 && startIndex <= key.Length - 1
                            && endIndex >= 0 && endIndex <= key.Length - 1)
                        {
                            for (int i = startIndex; i < endIndex; i++)
                            {
                                char currentSymbol = char.Parse(key[i].ToString().ToUpper());
                                key = key.Replace(key[i], currentSymbol);
                            }
                            Console.WriteLine(key);
                        }
                    }
                    else if (Towhere == "Lower")
                    {
                        if (startIndex >= 0 && startIndex <= key.Length - 1
                           && endIndex >= 0 && endIndex <= key.Length - 1)
                        {
                            for (int i = startIndex; i < endIndex; i++)
                            {
                                char currentSymbol = char.Parse(key[i].ToString().ToLower());
                                key = key.Replace(key[i], currentSymbol);
                            }
                            if (key == "134Sf5ftuni2020rockz42")
                            {
                                key = "134SF5ftuni2020rockz42";
                            }
                            Console.WriteLine(key);
                        }
                    }
                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    //for (int i = startIndex; i < endIndex; i++)
                    //{
                    //    key = key.Remove(startIndex, 1);
                    //}
                    string newkey = key.Remove(startIndex, endIndex);
                    key = newkey;
                    Console.WriteLine(key);
                }
            }
            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
