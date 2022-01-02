using System;
using System.Text;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input = String.Empty;
            while ((input = Console.ReadLine()) != "Done")
            {
                string[] commands = input.Split();
                string command = commands[0];

                switch (command)
                {
                    case "TakeOdd":
                        StringBuilder sb = new StringBuilder();
                        for (var i = 0; i < text.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                sb.Append(text[i]);
                            }
                        }

                        text = sb.ToString();
                        Console.WriteLine(text);
                        break;
                    case "Cut":
                        int index = int.Parse(commands[1]);
                        int length = int.Parse(commands[2]);
                        text = text.Remove(index, length);
                        Console.WriteLine(text);
                        break;
                    case "Substitute":
                        string substring = commands[1];
                        string substitute = commands[2];

                        if (text.Contains(substring))
                        {
                            while (text.Contains(substring))
                            {
                                text = text.Replace(substring, substitute);
                            }

                            Console.WriteLine(text);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
            }

            Console.WriteLine($"Your password is: {text}");
        }
    }
}
