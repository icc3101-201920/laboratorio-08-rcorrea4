using Laboratorio_7_OOP_201902.Cards;
using Laboratorio_7_OOP_201902.Static;
using System;
using System.Collections.Generic;

namespace Laboratorio_7_OOP_201902
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine("Do you want to load the game? 0:Yes - 1:No");
            int userInput = Visualization.GetUserInput(1);
            if (userInput == 0)
            {
                Game.loadData();
            }
            game.Play();
            
            



        }
    }
}
