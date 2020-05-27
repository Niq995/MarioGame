using Microsoft.Xna.Framework;
using Sprite0.Sprite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprite0.Command
{
    class CommandLeftRight : ICommand
    {
        public Game1 Game;

        public CommandLeftRight(Game1 game)
        {
            Game = game;
        }

        public void Execute()
        {
            Game.sprite = new SpriteAnimatedLeftRight(Game.MarioRunLeft,4,4,new Vector2 (400,200));
        }
    }
}
