using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprite0.Sprite;

namespace Sprite0.Sprite
{
    class SpriteStaticUpdown : ISprite
    {
        public Texture2D Texture { get; set; } //表示该属性可以获取和设置
        public Vector2 location;

        //Constructor
        public SpriteStaticUpdown(Texture2D texture, Vector2 loc)
        {
            Texture = texture;
            location = loc;
            //height = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
        }
        public void Update()
        {
            location.Y--;
            if (this.location.Y < 0)
                this.location.Y = 350;

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, this.location, Color.White);
            spriteBatch.End();
        }
    }

        
    
}
