using System;

namespace Задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double familyIncome = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            double socialScholarship = Math.Floor(minimalSalary * 0.35);
            double scholarshipForExcellentAchievement = Math.Floor( averageSuccess * 25);

           
        
            if (familyIncome < minimalSalary && averageSuccess > 4.5 && averageSuccess <= 5.5 )
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }

            else if (familyIncome > minimalSalary && averageSuccess >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarshipForExcellentAchievement} BGN");
            }

            else if ( familyIncome < minimalSalary && averageSuccess >= 5.5)
            {
                if(socialScholarship > scholarshipForExcellentAchievement)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }
                  
                else if (socialScholarship < scholarshipForExcellentAchievement)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {scholarshipForExcellentAchievement} BGN");
                }

                else if (socialScholarship == scholarshipForExcellentAchievement)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {scholarshipForExcellentAchievement} BGN");
                }

            }

            else 
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

        }
    }
}
