using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var sportCar = new SportCar(5,3.3);
            sportCar.Drive(5);

            Console.WriteLine(sportCar.Fuel);

        }
    }
}
