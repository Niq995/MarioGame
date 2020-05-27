using Microsoft.Xna.Framework.Input;
using Sprite0.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprite0
{
    class ControllerKeyboard : IController
    {
        public Dictionary<Keys, ICommand> KeyboardMap;  //有很多按钮的遥控器

        public ControllerKeyboard()
        {
            KeyboardMap = new Dictionary<Keys, ICommand>();
        }

        public void SetCommand(Game1 game)    //设置该遥控器上有的按钮们的命令
        {
            KeyboardMap.Add(Keys.D0, new CommandQuit(game));
            KeyboardMap.Add(Keys.D1, new CommandResting(game));
            KeyboardMap.Add(Keys.D2, new CommandAnimated(game));
            KeyboardMap.Add(Keys.D3, new CommandUpDown(game));
            KeyboardMap.Add(Keys.D4, new CommandLeftRight(game));

        }

        public void Update()
        {
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();
            foreach (Keys key in pressedKeys)
            {
                if (key.Equals(Keys.D0) || key.Equals(Keys.D1) || key.Equals(Keys.D2) || key.Equals(Keys.D3) || key.Equals(Keys.D4))
                {
                    KeyboardMap[key].Execute();
                }
            }
        }
        
    }
}
