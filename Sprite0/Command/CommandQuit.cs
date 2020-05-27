using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprite0.Command
{
    class CommandQuit : ICommand
    {
        private Game1 Game;

        public CommandQuit(Game1 game)
        {
            Game = game;
        }



        public void Execute()
        {
            Game.Exit();
        }
    }
}
