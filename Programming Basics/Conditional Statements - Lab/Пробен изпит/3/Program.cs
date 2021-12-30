using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cakeType = Console.ReadLine();
            int numOrderedCakes = int.Parse(Console.ReadLine());
            int dayBeforeChrismas = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            double discount = 0;

            switch(cakeType)
            {
                case "Cake":

                    if (dayBeforeChrismas <= 15)
                    {
                        totalPrice = numOrderedCakes * 24;
                    }
                    if(dayBeforeChrismas > 15)
                    {
                        totalPrice = numOrderedCakes * 28.70;
                    }
                        break;

                case "Souffle":
                    if (dayBeforeChrismas <= 15)
                    {
                        totalPrice = numOrderedCakes * 6.66;
                    }
                    if(dayBeforeChrismas > 15)
                    {
                        totalPrice = numOrderedCakes * 9.80;
                    }
                    break;

                case "Baklava":
                    if (dayBeforeChrismas <= 15)
                    {
                        totalPrice = numOrderedCakes * 12.60;
                    }
                    if(dayBeforeChrismas > 15)
                    {
                        totalPrice = numOrderedCakes * 16.98;
                    }
                    break;    
            }

            if ( dayBeforeChrismas <= 22)
            {
                if (totalPrice >= 100 && totalPrice <= 200)
                {
                    discount = totalPrice * 0.15;
                    totalPrice -= discount;
                }
                if (totalPrice > 200)
                {
                    discount = totalPrice * 0.25;
                    totalPrice -= discount;
                }
                if (dayBeforeChrismas <= 15)
                {
                    discount = totalPrice * 0.10;
                    totalPrice -= discount;
                }
            }

            Console.WriteLine($"{totalPrice:f2}"); 
            
        }
    }
}
