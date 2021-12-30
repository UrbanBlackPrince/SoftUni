using System;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {


            string figure = Console.ReadLine();
            double side = double.Parse(Console.ReadLine());
           


            if (figure == "square") 
            {
                double face = side * side;
                Console.WriteLine(face);
            }

            else if (figure == "rectangle")
            {
                double secondSide = double.Parse(Console.ReadLine());
                double face = side * secondSide;
                Console.WriteLine(face);

            }

            else if (figure == "circle")
            {
                double face = side * side * Math.PI;
                Console.WriteLine(face);
            }
             
            else if (figure == "triangle")
            {
                double hight = double.Parse(Console.ReadLine());
                double face = side * hight / 2;
                Console.WriteLine(face);

            }






        }
    }
}
