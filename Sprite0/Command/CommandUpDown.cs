using Microsoft.Xna.Framework;
using Sprite0.Sprite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprite0.Command
{
    class CommandUpDown : ICommand
    {
        public Game1 Game;

        public CommandUpDown(Game1 game)
        {
            Game = game ;
        }
        
        public void Execute()
        {
            Game.sprite = new SpriteStaticUpdown(Game.MarioStandLeft,new Vector2(400,200));
        }
    }
}
