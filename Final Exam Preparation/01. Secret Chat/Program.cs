using System;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] tokens = command.Split(":");
                string type = tokens[0];
                if (type == "Add Stop")
                {
                    int index = int.Parse(tokens[1]);
                    string replacement = tokens[2];

                    if (index >= 0 && index <= input.Length)
                    {
                        string novString = input.Insert(index, replacement);
                        input = novString;
                    }
                }
                if (type == "Remove Stop")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    string novString = string.Empty;

                    if (startIndex >= 0 && startIndex <= input.Length && endIndex >= 0 && endIndex <= input.Length)
                    {
                        novString = input.(startIndex, endIndex - startIndex);
                    }
                    input = novString;
                }
                if (type == "Switch")
                {
                    string old = tokens[1];
                    string nov = tokens[2];
                    string newString = string.Empty;

                    if (input.Contains(old))
                    {
                        newString = input.Replace(old, nov);
                    }
                    input = newString;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
