using System;

namespace Задача_8
{
    class Program
    {
        static void Main(string[] args)
        {

            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volumeFishTank = lenght * width * hight;
            double totalLitresFishTank = volumeFishTank * 0.001;
            double percentShit = percent * 0.01 ;
            double totalLitresNeed = totalLitresFishTank * (1 - percentShit);

            Console.WriteLine(totalLitresNeed);








        }
    }
}
