using Back_end_Development_Assignment_1.GameController;
using Back_end_Development_Assignment_1.Heroes;
using Back_end_Development_Assignment_1.Items;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_end_Development_Assignment_1
{
    internal class Program
    {
        [ExcludeFromCodeCoverage]
        static void Main(string[] args)
        {
            Game game = new Game();
            game.startGame();

        }
    }
}
