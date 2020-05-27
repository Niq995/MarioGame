using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprite0.Command
{
    class CommandResting : ICommand
    {
        public Game1 Game;

        public CommandResting(Game1 game)
        {
            Game = game;
        }



        public void Execute()
        {
            Game.sprite = new StaticSprite(Game.MarioStandRight);
        }
    }
}
