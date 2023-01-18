using Back_end_Development_Assignment_1.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Back_end_Development_Assignment_1.GameController
{
    public class GameFlow
    {

        public static Hero createHero()
        {
            Hero hero = null;

            while (hero == null)
            {
                hero = HeroCreation.createHero();
            }

            Console.WriteLine($"Welcome {hero.Name}! You selected the " + hero.GetType().Name + " class");
            Thread.Sleep(1000);
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();

            return hero;
        }
    }
}
