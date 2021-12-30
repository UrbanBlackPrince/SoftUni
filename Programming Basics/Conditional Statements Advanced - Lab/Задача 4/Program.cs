using System;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {

            double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();

            if (sex == "f")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }

                else if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
            }
             else if (sex == "m")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }    

                else if (age < 16)
                {
                    Console.WriteLine("Master");
                }
            }

        }
    }
}
