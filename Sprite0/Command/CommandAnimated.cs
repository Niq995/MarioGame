using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprite0.Command
{
    class CommandAnimated : ICommand
    {
        public Game1 Game;

        public CommandAnimated(Game1 game)
        {
            Game = game;
        }
        
        public void Execute()
        {
            Game.sprite = new AnimatedSprite(Game.MarioRunRight, 4, 4);
        }
    }
}
