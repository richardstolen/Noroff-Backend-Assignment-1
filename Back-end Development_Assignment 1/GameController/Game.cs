using Back_end_Development_Assignment_1.Enemies;
using Back_end_Development_Assignment_1.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
                mainMenu();
            }
        }

        public void mainMenu()
        {
            Console.WriteLine("Main menu, select a option\n");
            Console.WriteLine("1. Combat\n2. Show stats and equipment\n3. Load Game\n4. Save and exit\n5. New Game");
            int input = 0;
            try
            {
                input = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong, try again");
                Thread.Sleep(2000);
                mainMenu();
            }

            if (input == 1)
            {
                combat();
            }
            else if (input == 2)
            {
                Hero.displayHero();
            }
            else if (input == 3)
            {
                Hero = SaveAndLoadGame.loadGame();
            }
            else if (input == 4)
            {
                saveAndExit();
            }
            else if (input == 5)
            {
                Hero = GameFlow.createHero();
            }
            else
            {
                Console.WriteLine("Wrong input try again...");
                Thread.Sleep(2000);
                mainMenu();
            }
        }

        private void saveAndExit()
        {
            SaveAndLoadGame.saveGame(Hero);
            isRunning = false;
        }

        public void combat()
        {
            AngryBear enemy = new AngryBear(1, 101, 10, 3, "Angry Bear");
            Combat combat = new Combat(Hero, enemy);
            bool heroWin = combat.fight();

            if (heroWin)
            {
                Console.WriteLine("You killed the enemy!");
                Console.WriteLine("You received " + enemy.ExperienceDrop + " experience");
                Hero.addExperience(enemy.ExperienceDrop);

                Console.WriteLine("Press any key to go to main menu");
                Console.ReadKey();
                mainMenu();
            }
            else
            {
                Console.WriteLine("Game over, you died");
                Console.WriteLine("Press any key to go to main menu");
                Console.ReadKey();
                mainMenu();
            }
        }

    }
}
