using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    class SportCar : Car
    {
        private const double DefaultSportCarFuelConsumption = 10;

        public SportCar(int horsePower, double fuel)
            :base(horsePower,fuel)
        {

        }
        public override double FuelConsumption
              => DefaultSportCarFuelConsumption;
    }
}
