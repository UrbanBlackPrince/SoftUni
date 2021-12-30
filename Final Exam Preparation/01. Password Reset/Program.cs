using System;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] tokens = command.Split();
                string type = tokens[0];
                if (type == "TakeOdd")
                {
                    StringBuilder odd = new StringBuilder();
                    for (int i = 1; i < input.Length; i += 2)
                    {
                        odd.Append(input[i]);
                    }
                    input = odd.ToString();
                }
                if (type == "Cut")
                {
                    int index = int.Parse(tokens[1]);
                    int lenght = int.Parse(tokens[2]);
                    string newstring = input.Remove(index, lenght);
                    input = newstring;
                }
                if (type == "Substitute")
                {
                    string old = tokens[1];
                    string nel = tokens[2];
                    if (input.Contains(old))
                    {
                        string newstring = input.Replace(old, nel);
                        input = newstring;
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace! ");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {input} ");
        }
    }
}
