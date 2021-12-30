using System;

namespace Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {


            string name = Console.ReadLine();
            int numProjects = int.Parse(Console.ReadLine());

            int hourOfProjects = numProjects * 3;

            Console.WriteLine($"The architect {name} will need {hourOfProjects} hours to complete {numProjects} project/s.");










        }
    }
}
