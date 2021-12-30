using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var darkwizard = new DarkWizard("gogi",5);
            Console.WriteLine(darkwizard.ToString());
        }
    }
}