using System;

namespace Задача_12
{
    class Program
    {
        static void Main(string[] args)
        {

            string city = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());

            double commission = 0;

            if (num >= 0 && num <= 500)
            {
                switch (city)
                {
                    case "Sofia":
                        {
                            commission = 0.05;
                            double total = commission * num;
                            Console.WriteLine($"{total:f2}");
                            break;
                        }

                    case "Varna":
                        {
                            commission = 0.045;
                            double total = commission * num;
                            Console.WriteLine($"{total:f2}");
                            break;
                        }

                    case "Plovdiv":
                        {
                            commission = 0.055;
                            double total = commission * num;
                            Console.WriteLine($"{total:f2}");
                            break;
                        }

                    default:
                        Console.WriteLine("error");
                        break;
                }


            }

            else if (num > 500 && num <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        {
                            commission = 0.07;
                            double total = commission * num;
                            Console.WriteLine($"{total:f2}");
                            break;
                        }

                    case "Varna":
                        {
                            commission = 0.075;
                            double total = commission * num;
                            Console.WriteLine($"{total:f2}");
                            break;
                        }

                    case "Plovdiv":
                        {
                            commission = 0.08;
                            double total = commission * num;
                            Console.WriteLine($"{total:f2}");
                            break;
                        }

                    default:
                        Console.WriteLine("error");
                        break;
                }


            }

            else if (num > 1000 && num <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        {
                            commission = 0.08; ;
                            double total = commission * num;
                            Console.WriteLine($"{total:f2}");
                            break;
                        }

                    case "Varna":
                        {
                            commission = 0.1;
                            double total = commission * num;
                            Console.WriteLine($"{total:f2}");
                            break;
                        }

                    case "Plovdiv":
                        {
                            commission = 0.12;
                            double total = commission * num;
                            Console.WriteLine($"{total:f2}");
                            break;
                        }

                    default:
                        Console.WriteLine("error");
                        break;
                }


            }

            else if (num > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        {
                            commission = 0.12;
                            double total = commission * num;
                            Console.WriteLine($"{total:f2}");
                            break;
                        }

                    case "Varna":
                        {
                            commission = 0.13;
                            double total = commission * num;
                            Console.WriteLine($"{total:f2}");
                            break;
                        }

                    case "Plovdiv":
                        {
                            commission = 0.145;
                            double total = commission * num;
                            Console.WriteLine($"{total:f2}");
                            break;
                        }

                    default:
                        Console.WriteLine("error");
                        break;
                }


            }

            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
