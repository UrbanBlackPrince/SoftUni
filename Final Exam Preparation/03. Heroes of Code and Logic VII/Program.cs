using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> totalHP = new Dictionary<string, int>();
            Dictionary<string, int> totalMana = new Dictionary<string, int>();


            for (int counter = 0; counter < n; counter++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string heroName = input[0];
                int HP = int.Parse(input[1]);
                int Mana = int.Parse(input[2]);

                totalHP[heroName] = HP;
                totalMana[heroName] = Mana;
            }
            var command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (command[0] != "End")
            {
                if (command[0] == "Heal")
                {
                    string name = command[1];
                    int healed = int.Parse(command[2]);

                    int hitPointHave = totalHP[name];

                    totalHP[name] += healed;

                    if (totalHP[name] > 100)
                    {
                        totalHP[name] = 100;

                        int realHealth = totalHP[name] - hitPointHave;

                        Console.WriteLine($"{name} healed for {realHealth} HP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} healed for {healed} HP!");
                    }
                }
                else if (command[0] == "Recharge")
                {
                    string name = command[1];
                    int manaed = int.Parse(command[2]);

                    int manaHave = totalMana[name];

                    totalMana[name] += manaed;

                    if (totalMana[name] > 200)
                    {
                        totalMana[name] = 200;

                        int realMana = totalMana[name] - manaHave;

                        Console.WriteLine($"{name} recharged for {realMana} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} recharged for {manaed} MP!");
                    }
                }
                else if (command[0] == "TakeDamage")
                {
                    string name = command[1];
                    int damage = int.Parse(command[2]);
                    string atacker = command[3];

                    totalHP[name] -= damage;

                    if (totalHP[name] > 0)
                    {
                        Console.WriteLine($"{name} was hit for {damage} HP by {atacker} and now has {totalHP[name]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} has been killed by {atacker}!");
                    }
                }
                else if (command[0] == "CastSpell")
                {
                    string name = command[1];
                    int MPNeed = int.Parse(command[2]);
                    string spellName = command[3];

                    totalMana[name] -= MPNeed;

                    if (totalMana[name] > 0)
                    {
                        Console.WriteLine($"{name} has successfully cast {spellName} and now has { totalMana[name]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                }
                command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }


            Dictionary<string, int> stillAlive = totalHP
               .Where(x => x.Value > 0)
               .OrderByDescending(x => x.Value)
               .ThenBy(x => x.Key)
               .ToDictionary(x => x.Key, x => x.Value);

            foreach (var hero in stillAlive)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value}");
                Console.WriteLine($"  MP: {totalMana[hero.Key]}");
            }

        }
    }
}
