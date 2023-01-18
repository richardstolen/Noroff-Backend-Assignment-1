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

        public void startGame()
        {
            isRunning = true;
            while (isRunning)
            {
                if (Hero == null)
                {
                    Hero = GameFlow.createHero();
                }
                Console.WriteLine("You created a hero");
                Console.ReadKey();
            }
        }

    }
}
