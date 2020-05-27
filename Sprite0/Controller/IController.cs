using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprite0
{
    public interface IController
    {
        void SetCommand(Game1 Game);
        void Update();
    }
}
