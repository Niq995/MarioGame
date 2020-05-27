using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprite0.Sprite;

namespace Sprite0
{
    class SpriteStatic : ISprite
    {
        public Texture2D Texture { get; set; } //表示该属性可以获取和设置
        //Vector2 location;

        //Constructor
        public SpriteStatic(Texture2D texture)
        {
            Texture = texture;
            //Columns = columns;
        }
        public void Update()
        {
            //no need for static sprite to update its state
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, location, Color.White);
            spriteBatch.End();
        }
    }
}
