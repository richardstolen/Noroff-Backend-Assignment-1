using Back_end_Development_Assignment_1.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Back_end_Development_Assignment_1.GameController
{
    public class HeroCreation
    {
        public static Hero createHero()
        {
            Hero hero = null;

            while (hero == null)
            {

                int input = 0;
                Console.WriteLine("Choose your hero!");
                Console.WriteLine("1. Mage\n2. Ranger\n3. Rogue\n4. Warrior");
                try
                {
                    input = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong, try again");
                    Thread.Sleep(3000);
                    createHero();
                }
                HeroClasses heroClass = HeroClasses.Mage;

                if (input == 1)
                {
                    heroClass = HeroClasses.Mage;
                }
                else if (input == 2)
                {
                    heroClass = HeroClasses.Ranger;
                }
                else if (input == 3)
                {
                    heroClass = HeroClasses.Rogue;
                }
                else if (input == 4)
                {
                    heroClass = HeroClasses.Warrior;
                }
                else
                {
                    Console.WriteLine("Wrong input try again...");
                    Thread.Sleep(3000);
                    createHero();
                }

                Console.WriteLine("Type the name of you hero");
                string name = Console.ReadLine();

                while (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Bad input, try again");
                    name = Console.ReadLine();
                }
                hero = HeroFactory.Create(heroClass, name);
            }

            return hero;

        }
    }
}
