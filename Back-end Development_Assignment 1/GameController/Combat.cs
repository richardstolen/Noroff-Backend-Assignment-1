using Back_end_Development_Assignment_1.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Back_end_Development_Assignment_1.GameController
{
    public class Combat
    {
        public Hero Hero { get; set; }
        public Enemy Enemy { get; set; }

        public Combat(Hero Hero, Enemy Enemy)
        {
            this.Hero = Hero;
            this.Enemy = Enemy;

            Console.WriteLine("You encountered a " + Enemy.Name + " ! Press any key to start the combat");
            Console.ReadKey();

        }


        public bool fight()
        {
            bool fighting = true;
            bool heroWin = false;

            while (fighting)
            {
                if (Hero.Health <= 0)
                {
                    fighting = false;
                    break;

                }
                if (Enemy.Health <= 0)
                {
                    heroWin = true;
                    fighting = false;
                    break;
                }

                double heroDmg = Hero.damage();
                double enemyDmg = Enemy.attack(Hero);

                Hero.Health -= enemyDmg;
                Enemy.Health -= heroDmg;

                Console.WriteLine($"Your autoattack did {heroDmg} damage, the {Enemy.Name}'s health is now {Enemy.Health}\n");

                Console.WriteLine($"The enemy attack did {enemyDmg} damage, your health is now {Hero.Health}");
                Thread.Sleep(500);
                Console.WriteLine("\n Press any key to continue the fight");
                Console.ReadKey();
                Console.Clear();


            }
            return heroWin;
        }
    }
}
