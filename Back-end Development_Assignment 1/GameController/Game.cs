using Back_end_Development_Assignment_1.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_end_Development_Assignment_1.GameController
{
    public class Game
    {
        public Hero Hero { get; set; }

        public bool isRunning { get; set; } = false;



        AngryBear enemy = new AngryBear(1, 25, 20, 3, "Angry Bear");

        public void startGame()
        {
            isRunning = true;
            while (isRunning)
            {
                if (Hero == null)
                {
                    Hero = GameFlow.createHero();
                }

                AngryBear enemy = new AngryBear(1, 101, 10, 3, "Angry Bear");
                Combat combat = new Combat(Hero, enemy);
                bool heroWin = combat.fight();

                if (heroWin)
                {
                    Console.WriteLine("You killed the enemy!");
                    Console.WriteLine("You received " + enemy.ExperienceDrop + " experience");
                    Hero.addExperience(enemy.ExperienceDrop);

                    Console.WriteLine("Press any key to fight a new enemy");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Game over, you died");
                    Console.WriteLine("Press any key to start again");
                    Console.ReadKey();
                    startGame();
                }
            }
        }

    }
}
